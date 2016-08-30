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

        // Properties
        public string Name
        {
            get {return name;}
        }

        public Point Position
        {
            get { return position; }
        }

        // Constructors
        public Actor(Point position, string name)
        {
            this.position = position;
            this.name = name;
        }

        // Methods
    }
}
