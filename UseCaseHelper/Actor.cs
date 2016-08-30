using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    class Actor
    {
        // Fields
        string name;
        Point position;
        Rectangle rect;

        // Properties
        public string Name
        {
            get {return name;}
        }

        public Point Position
        {
            get { return position; }
        }

        public Rectangle Rect
        {
            get { return rect;}
        }

        // Constructors
        public Actor(Point position, string name)
        {
            this.position = position;
            this.name = name;
        }

        // Methods
        public void setBoundries(Rectangle rect)
        {
            this.rect = rect;
        }

        public bool isHit(Point mousePosition)
        {
            if (rect.Contains(mousePosition))
                return true;
            else
                return false;
        }
    }
}
