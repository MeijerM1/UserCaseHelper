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
        Rectangle rect;
        

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
        }
        public Rectangle Rect
        {
            get { return rect; }
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
