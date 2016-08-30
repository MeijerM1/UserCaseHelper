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

        public Form1()
        {
            InitializeComponent();
        }

        private void createActor(Point mousePosition)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Give the actors name:", "Actor naming", "example");
            actors.Add(new Actor(mousePosition, name));
            panel1.Invalidate();
        }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Image imag = Image.FromFile(@"C:\Users\max1_\Source\Repos\UserCaseHelper\UseCaseHelper\obj\actor.png");
            Pen blackPen = new Pen(Color.Black, 1);

            SolidBrush sbr = new SolidBrush(Color.Black);
            FontFamily fam = new FontFamily("Arial");
            Font font = new System.Drawing.Font(fam, 10, FontStyle.Bold);
            
            foreach (Actor a in actors)
            {
                e.Graphics.DrawImage(imag, (a.Position.X - (imag.Width/2)), (a.Position.Y - (imag.Height / 2)));
                e.Graphics.DrawString(a.Name, font, sbr,(a.Position.X - (imag.Width / 2 + 10))  ,(a.Position.Y + imag.Height / 2));
            }
            foreach(UserCase u in useCases)
            {
                SizeF stringSize = new SizeF();
                stringSize = e.Graphics.MeasureString(u.Name, font);
                e.Graphics.DrawString(u.Name, font, sbr, Convert.ToInt32(u.Position.X - stringSize.Width/2 + stringSize.Width * 0.1),Convert.ToInt32( u.Position.Y - stringSize.Height/2 - stringSize.Height * 0.005));

                Rectangle rt = new Rectangle();
                rt.X = u.Position.X - Convert.ToInt32(stringSize.Width / 2);
                rt.Y = u.Position.Y - Convert.ToInt32 (stringSize.Height / 2);

                rt.Width = Convert.ToInt32(stringSize.Width + Convert.ToInt32(stringSize.Width * 0.1));
                rt.Height = Convert.ToInt32(stringSize.Height + Convert.ToInt32(stringSize.Height * 0.3));


                e.Graphics.DrawEllipse(blackPen, rt);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);
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
                //Placeholder
            }
            else
                return;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            actors.Clear();
            panel1.Invalidate();
        }
    }
}
