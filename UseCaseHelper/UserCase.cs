using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UseCaseHelper
{
    class UserCase
    {
        // Fields 
        string name;
        string summary;
        string actors;
        string assumption;
        string description;
        string exception;
        string result;
        Point position;
        Point connectPosition;
        Rectangle rect;
        SizeF stringSize;
        

        // Properties
        public string Name
        {
            get { return name; }

        }
        public string Summary
        {
            get { return summary; }
            set { this.summary = value; }
        }
        public string Actors
        {
            get { return actors; }
            set { this.actors = value; }
        }
        public string Assumption
        {
            get { return assumption; }
            set { this.assumption = value; }
        }
        public string Description
        {
            get { return description; }
            set { this.description = value; }
        }
        public string Exception
        {
            get { return exception; }
            set { this.exception = value; }
        }
        public string Result
        {
            get { return result; }
            set { this.result = value; }
        }
        public Point Position
        {
            get { return position; }
            set { this.position = value; }
        }

        public Point ConnectPosition
        {
            get { return connectPosition; }
        }

        public Rectangle Rect
        {
            get { return rect; }
        }

        public SizeF StringSize
        {
            get { return stringSize; }
            set { this.stringSize = value; }
        }

        // Constructors
        public UserCase(Point position, string name, string summary, string actors, string assumption, string description, string exception, string result)
        {
            this.position = position;
            this.name = name;
            this.summary = summary;
            this.actors = actors;
            this.assumption = assumption;
            this.description = description;
            this.exception = exception;
            this.result = result;
        }

        // Methods
        private void setConnectPosition()
        {
            connectPosition = new Point(position.X - rect.Width / 2, position.Y + 5);
        }

        public void setBoundries(Rectangle rect)
        {
            this.rect = rect;
            setConnectPosition();
        }

        public void movePosition(Point position)
        {
            this.position = position;
            rect.Location = position;

            rect.X = Convert.ToInt32(Position.X - stringSize.Width / 2);
            rect.Y = Convert.ToInt32(Position.Y - stringSize.Height / 2);

            setConnectPosition();
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
