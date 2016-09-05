using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace UseCaseHelper
{
    public partial class Form1 : Form
    {
        Dictionary<int, Actor> actors = new Dictionary<int, Actor>();
        Dictionary<int, UseCase> useCases = new Dictionary<int, UseCase>();
        formProperties fp = new formProperties();

        int selectedActor;
        int selectedUseCase;
        int activeActorIndex = -1;
        int activeUseCaseIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        //
        // Function that creates an actor and adds it to the list of actors.
        // Will invalidate the draw panel to make sure it shows up.
        //
        private void createActor(Point mousePosition)
        {

            string name = Microsoft.VisualBasic.Interaction.InputBox("Give the actors name:", "Actor naming", "example");
            if (name == "")
                return;
            actors.Add(actors.Count + 1, new Actor(mousePosition, name));

            Image imag = Image.FromFile(@"C:\Users\max1_\Source\Repos\UserCaseHelper\UseCaseHelper\obj\actor.png");

            Rectangle rect = new Rectangle();
            rect.Width = imag.Width;
            rect.Height = imag.Height;
            rect.X = (actors[actors.Count].Position.X - (imag.Width / 2));
            rect.Y = (actors[actors.Count].Position.Y - (imag.Height / 2));

            actors[actors.Count].setBoundries(rect);
            panel1.Invalidate();
        }

        //
        // Function that creates a new use case class based on the information entered on the second form
        // Adds said use case to the list of use cases and invalidates the panel to draw
        //
        public void createUseCase(Point mousePosition)
        {
            if (fp.ShowDialog() == DialogResult.OK)
            {
                string name = fp.UseCaseName;
                string summary = fp.Summary;
                string actor = fp.Actor;
                string assumption = fp.Assumption;
                string description = fp.Description;
                string exception = fp.Exception;
                string result = fp.Result;

                useCases.Add(useCases.Count + 1, new UseCase(mousePosition, name, summary, actor, assumption, description, exception, result));
            }
            FontFamily fam = new FontFamily("Arial");
            Font font = new System.Drawing.Font(fam, 10, FontStyle.Bold);

            Graphics g = panel1.CreateGraphics();

            SizeF stringSize = new SizeF();
            stringSize = g.MeasureString(useCases[useCases.Count].Name, font);

            useCases[useCases.Count].StringSize = stringSize;

            Rectangle rect = new Rectangle();
            rect.X = Convert.ToInt32(useCases[useCases.Count].Position.X - stringSize.Width / 2);
            rect.Y = Convert.ToInt32(useCases[useCases.Count].Position.Y - stringSize.Height / 2);

            rect.Width = Convert.ToInt32(stringSize.Width + Convert.ToInt32(stringSize.Width * 0.1));
            rect.Height = Convert.ToInt32(stringSize.Height + Convert.ToInt32(stringSize.Height * 0.6));

            useCases[useCases.Count].setBoundries(rect);
            panel1.Invalidate();
        }

        //
        // Function that draws red outlining around the selected item
        // Outlining will disappear when the panel is invalidated
        // Is called from the isHit function
        //
        private void drawSelection(Rectangle rect)
        {
            panel1.Refresh();
            Graphics g = panel1.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 1);
            g.DrawRectangle(redPen, rect);
        }

        private void checkConnectionHit(Point mousePosition)
        {
            foreach (KeyValuePair<int, Actor> a in actors)
            {
                if (a.Value.isHit(mousePosition))
                {
                    drawSelection(a.Value.Rect);
                    selectedActor = a.Key;
                }
            }
            foreach (KeyValuePair<int, UseCase> u in useCases)
            {
                if (u.Value.isHit(mousePosition))
                    selectedUseCase = u.Key;
            }

            if (selectedActor > 0 && selectedUseCase > 0)
            {
                actors[selectedActor].addRelation(selectedUseCase);
                selectedActor = 0;
                selectedUseCase = 0;
                panel1.Invalidate();
            }
        }

        private void drawConectionLine(List<Point> points)
        {
            Graphics g = panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 2);
            g.DrawLine(blackPen, points[0], points[1]);
        }

        //
        // Called when a use case is selected
        // Sets all the forms textboxes to represent the selected use case and opens the form
        //
        private void getUseCaseInformation(UseCase u)
        {
            fp.UseCaseName = u.Name;
            fp.Summary = u.Summary;
            fp.Actor = u.Actors;
            fp.Assumption = u.Assumption;
            fp.Description = u.Description;
            fp.Exception = u.Exception;
            fp.Result = u.Result;
            if (fp.ShowDialog() == DialogResult.OK)
            {
                u.Name = fp.UseCaseName;
                u.Summary = fp.Summary;
                u.Actors = fp.Actor;
                u.Assumption = fp.Assumption;
                u.Description = fp.Description;
                u.Exception = fp.Exception;
                u.Result = fp.Result;
            }
        }

        // 
        // Called when the mouse is clicked on the panel
        // Goed through all the actors and use cases to see if they intersect with the mouse position
        // When it does it will call the drawOutline function
        //
        private int checkActorHit(Point mousePosition)
        {
            foreach (KeyValuePair<int, Actor> a in actors)
            {
                if (a.Value.isHit(mousePosition))
                {
                    return a.Key;
                }
            }
            return -1;
        }

        private int checkUseCaseHit(Point mousePosition)
        {
            foreach (KeyValuePair<int, UseCase> u in useCases)
            {
                if (u.Value.isHit(mousePosition))
                {
                    return u.Key;
                }
            }
            return -1;
        }

        private void drawActors(PaintEventArgs e, Image imag, Font font, SolidBrush sbr, Pen blackPen)
        {
            foreach (KeyValuePair<int, Actor> a in actors)
            {
                SizeF stringSize = new SizeF();
                stringSize = e.Graphics.MeasureString(a.Value.Name, font);

                e.Graphics.DrawImage(imag, a.Value.Rect);
                e.Graphics.DrawString(a.Value.Name, font, sbr, (a.Value.Position.X - stringSize.Width / 2), (a.Value.Position.Y + imag.Height / 2));

                List<int> relations = a.Value.giveRelations();
                if (relations.Count > 0)
                {
                    foreach (int r in relations)
                    {
                        try
                        {
                            e.Graphics.DrawLine(blackPen, a.Value.ConnectPoint, useCases[r].ConnectPosition);
                        }
                        catch (KeyNotFoundException)
                        { }
                    }
                }
            }
        }
        private void drawUseCases(PaintEventArgs e, Font font, SolidBrush sbr, Pen blackPen)
        {
            foreach (KeyValuePair<int, UseCase> u in useCases)
            {
                SizeF stringSize = new SizeF();
                stringSize = e.Graphics.MeasureString(u.Value.Name, font);

                e.Graphics.DrawString(u.Value.Name, font, sbr, Convert.ToInt32(u.Value.Position.X - stringSize.Width / 2 + stringSize.Width * 0.1), Convert.ToInt32(u.Value.Position.Y - stringSize.Height / 2 + stringSize.Height * 0.3));
                e.Graphics.DrawEllipse(blackPen, u.Value.Rect);
            }
        }

        private void drawActiveActor()
        {
            Graphics g = panel1.CreateGraphics();
            Image imag = Image.FromFile(@"C:\Users\max1_\Source\Repos\UserCaseHelper\UseCaseHelper\obj\actor.png");
            SolidBrush sbr = new SolidBrush(Color.Black);
            FontFamily fam = new FontFamily("Arial");
            Font font = new System.Drawing.Font(fam, 10, FontStyle.Bold);

            SizeF stringSize = new SizeF();
            stringSize = g.MeasureString(actors[activeActorIndex].Name, font);

            g.DrawImage(imag, actors[activeActorIndex].Rect);
            g.DrawString(actors[activeActorIndex].Name, font, sbr, (actors[activeActorIndex].Position.X - stringSize.Width / 2), (actors[activeActorIndex].Position.Y + imag.Height / 2));

            panel1.Invalidate();
        }

        private void drawActiveUseCase()
        {
            Graphics g = panel1.CreateGraphics();
            SolidBrush sbr = new SolidBrush(Color.Black);
            FontFamily fam = new FontFamily("Arial");
            Font font = new System.Drawing.Font(fam, 10, FontStyle.Bold);
            Pen blackPen = new Pen(Color.Black, 1);

            SizeF stringSize = new SizeF();
            stringSize = g.MeasureString(useCases[activeUseCaseIndex].Name, font);

            g.DrawString(useCases[activeUseCaseIndex].Name, font, sbr, Convert.ToInt32(useCases[activeUseCaseIndex].Position.X - stringSize.Width / 2 + stringSize.Width * 0.1), Convert.ToInt32(useCases[activeUseCaseIndex].Position.Y - stringSize.Height / 2 + stringSize.Height * 0.3));
            g.DrawEllipse(blackPen, useCases[activeUseCaseIndex].Rect);

            panel1.Invalidate();
        }
        // 
        // All permanent drawing happens here
        //
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Image imag = Image.FromFile(@"C:\Users\max1_\Source\Repos\UserCaseHelper\UseCaseHelper\obj\actor.png");
            Pen blackPen = new Pen(Color.Black, 1);

            SolidBrush sbr = new SolidBrush(Color.Black);
            FontFamily fam = new FontFamily("Arial");
            Font font = new System.Drawing.Font(fam, 10, FontStyle.Bold);

            drawActors(e, imag, font, sbr, blackPen);
            drawUseCases(e, font, sbr, blackPen);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);
            if (rbCreate.Checked)
            {
                if (rbActor.Checked)
                {
                    createActor(mousePosition);
                }
                else if (rbUseCase.Checked)
                {
                    createUseCase(mousePosition);
                }
                else if (rbLine.Checked)
                {
                    checkConnectionHit(mousePosition);
                }
                else
                    return;
            }
            else if (rbSelect.Checked)
            {
                int index = checkActorHit(mousePosition);
                if (index != -1)
                {
                    drawSelection(actors[index].Rect);
                    return;
                }
                else if ((index = checkUseCaseHit(mousePosition)) != -1)
                {
                    drawSelection(useCases[index].Rect);
                    getUseCaseInformation(useCases[index]);
                    return;
                }
                else
                    panel1.Invalidate();
                return;
            }
            else if (rbRemove.Checked)
            {
                int index = checkActorHit(mousePosition);
                if (index != -1)
                {
                    actors.Remove(index);
                    panel1.Invalidate();
                    return;
                }
                else if ((index = checkUseCaseHit(mousePosition)) != -1)
                {
                    useCases.Remove(index);
                    panel1.Invalidate();
                    return;
                }
                else
                    return;
            }
        }

        //
        // Clear tboth the actor and use cases lists
        // Invalidates the panel
        //
        private void btClear_Click(object sender, EventArgs e)
        {
            selectedActor = 0;
            selectedUseCase = 0;
            actors.Clear();
            useCases.Clear();
            panel1.Invalidate();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(panel1.Size.Width, panel1.Size.Height);
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, panel1.Size.Width, panel1.Size.Height));

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                bm.Save(sfd.FileName, format);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);
            if (rbMove.Checked)
            {
                activeActorIndex = checkActorHit(mousePosition);
                activeUseCaseIndex = checkUseCaseHit(mousePosition);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (activeActorIndex != -1 || activeUseCaseIndex != -1)
                panel1.Invalidate();

            activeUseCaseIndex = -1;
            activeActorIndex = -1;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rbMove.Checked)
            {
                Point mousePosition = new Point(e.X, e.Y);
                if (activeActorIndex != -1)
                {
                    actors[activeActorIndex].movePosition(mousePosition);
                    drawActiveActor();
                }
                else if (activeUseCaseIndex != -1)
                {
                    useCases[activeUseCaseIndex].movePosition(mousePosition);
                    drawActiveUseCase();
                }
            }
        }
    }
}
