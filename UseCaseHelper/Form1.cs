using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class Form1 : Form
    {
        List<Actor> actors = new List<Actor>();
        List<UserCase> useCases = new List<UserCase>();        
        formProperties fp = new formProperties();
        List<Point> connectionPoints = new List<Point>();
        bool remove = false;

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
            actors.Add(new Actor(mousePosition, name));
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

                    useCases.Add(new UserCase(mousePosition, name, summary, actor, assumption, description, exception, result));
            }
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

            foreach(var a in actors)
            {
                if (a.isHit(mousePosition))
                    connectionPoints.Add(a.Position);
            }
            foreach(var u in useCases)
            {
                if (u.isHit(mousePosition))
                    connectionPoints.Add(u.Position);
            }

            if (connectionPoints.Count >= 2)
            {
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
        // Sets all the forms textboxes to represent the select use case and opens the form
        //
        private void getUseCaseInformation(UserCase u)
        {
            fp.UseCaseName = u.Name;
            fp.Summary = u.Summary;
            fp.Actor = u.Actors;
            fp.Assumption = u.Assumption;
            fp.Description = u.Description;
            fp.Exception = u.Exception;
            fp.Result = u.Result;
            fp.ShowDialog();
        }

        // 
        // Called when the mouse is clicked on the panel
        // Goed through all the actors and use cases to see if they intersect with the mouse position
        // When it does it will call the drawOutline function
        //
        private void checkHit(Point mousePosition)
        {
            foreach(Actor a in actors)
            {
                if (a.isHit(mousePosition))
                {
                    if (remove == false)
                    {
                        drawSelection(a.Rect);
                        return;
                    }
                    else
                    {
                        actors.Remove(a);
                        panel1.Invalidate();
                        return;
                    }
                }            
            }
            foreach(UserCase u in useCases)
            {
                if(u.isHit(mousePosition))
                {
                    if(remove == false)
                    {
                        drawSelection(u.Rect);
                        getUseCaseInformation(u);
                        return;
                    }
                    else
                    {
                        useCases.Remove(u);
                        panel1.Invalidate();
                        return;
                    }
                }
            }
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
            
            foreach (Actor a in actors)
            {
                SizeF stringSize = new SizeF();
                stringSize = e.Graphics.MeasureString(a.Name, font);

                Rectangle rect = new Rectangle();
                rect.Width = imag.Width;
                rect.Height = imag.Height;
                rect.X = (a.Position.X - (imag.Width / 2));
                rect.Y = (a.Position.Y - (imag.Height / 2));

                a.setBoundries(rect);

                e.Graphics.DrawImage(imag, rect);
                e.Graphics.DrawString(a.Name, font, sbr,(a.Position.X - stringSize.Width/2) ,(a.Position.Y + imag.Height / 2));
            }
            foreach(UserCase u in useCases)
            {
                SizeF stringSize = new SizeF();
                stringSize = e.Graphics.MeasureString(u.Name, font);
                e.Graphics.DrawString(u.Name, font, sbr, Convert.ToInt32(u.Position.X - stringSize.Width/2 + stringSize.Width * 0.1),Convert.ToInt32( u.Position.Y - stringSize.Height/2 + stringSize.Height * 0.3));

                Rectangle rect = new Rectangle();
                rect.X = u.Position.X - Convert.ToInt32(stringSize.Width / 2);
                rect.Y = u.Position.Y - Convert.ToInt32 (stringSize.Height / 2);

                rect.Width = Convert.ToInt32(stringSize.Width + Convert.ToInt32(stringSize.Width * 0.1));
                rect.Height = Convert.ToInt32(stringSize.Height + Convert.ToInt32(stringSize.Height * 0.6));

                u.setBoundries(rect);

                e.Graphics.DrawEllipse(blackPen, rect);
            }
            if(connectionPoints.Count % 2 == 0)
            {
                for (int i = 0; i < connectionPoints.Count; i++)
                {
                    e.Graphics.DrawLine(blackPen, connectionPoints[i], connectionPoints[i + 1]);
                    i++;
                }
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);
            if (rbCreate.Checked)
            {
                remove = false;
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
            else if(rbSelect.Checked)
            {
                checkHit(mousePosition);
                remove = false;
            }
            else if(rbRemove.Checked)
            {
                checkHit(mousePosition);
                remove = true;
            }
        }

        //
        // Clear tboth the actor and use cases lists
        // Invalidates the panel
        //
        private void btClear_Click(object sender, EventArgs e)
        {
            actors.Clear();
            useCases.Clear();
            connectionPoints.Clear();
            panel1.Invalidate();
        }
    }
}
