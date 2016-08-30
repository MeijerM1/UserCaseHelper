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
        

        // Properties
        public string Name
        {
            get { return name; }
        }
        public string Summary
        {
            get { return summary; }
        }
        public string Actors
        {
            get { return actors; }
        }
        public string Assumption
        {
            get { return assumption; }
        }
        public string Description
        {
            get { return description; }
        }
        public string Exception
        {
            get { return exception; }
        }
        public string Result
        {
            get { return result; }
        }
        public Point Position
        {
            get { return position; }
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
    }
}
