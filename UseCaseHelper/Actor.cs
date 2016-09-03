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
        Point connectPoint;
        Rectangle rect;
        List<int> relations = new List<int>();

        // Properties
        public string Name
        {
            get {return name;}
        }

        public Point Position
        {
            get { return position; }
            set { this.position = value; }
        }

        public Point ConnectPoint
        {
            get { return connectPoint; }
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
            setConnectionPoint();
        }

        public void movePosition(Point position)
        {
            this.position = position;
            rect.Location = position;
            rect.X = Position.X - (rect.Width / 2);
            rect.Y = Position.Y - (rect.Height / 2);
            setConnectionPoint();
        }

        private void setConnectionPoint()
        {
            connectPoint = new Point(position.X + (rect.Width / 2), position.Y);
        }

        public bool isHit(Point mousePosition)
        {
            if (rect.Contains(mousePosition))
                return true;
            else
                return false;
        }

        public void addRelation(int useCaseIndex)
        {
            relations.Add(useCaseIndex);
        }

        public List<int> giveRelations()
        {
            return relations;
        }
    }
}
