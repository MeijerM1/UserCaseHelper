using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UseCaseHelper
{
    class Relation
    {
        // Fields
        //Properties
        public Actor actor1
        {
            get;
            set;
        }
        public Actor actor2
        {
            get;
            set;
        }
        public UseCase useCase1
        {
            get;
            set;
        }
        public UseCase useCase2
        {
            get;
            set;
        }

        // Constructors
        public Relation()
        {

        }
        public Relation(Actor a)
        {
            actor1 = a;
        }
        public Relation (UseCase u)
        {
            useCase1 = u;
        }

        // Methods
        public void setActor(Actor a)
        {
            if (actor1 == null)
                actor1 = a;
            else if (actor1 != null || actor2 == null)
                actor2 = a;
            else
                return;
        }

        public void setUseCase(UseCase u)
        {
            if (useCase1 == null)
                useCase1 = u;
            else if (useCase1 != null || useCase2 == null)
                useCase2 = u;
            else
                return;
        }
        public bool isFree()
        {
            if (actor1 == null && actor2 == null && useCase1 == null && useCase2 == null)
                return true;
            else if (actor1 != null && actor2 == null && useCase1 == null && useCase2 == null)
                return true;
            else if (actor1 == null && actor2 == null && useCase1 != null && useCase2 == null)
                return true;
            else
                return false;
        }

        public List<Point> givePoints()
        {
            List<Point> points = new List<Point>();
            if(actor1 != null && actor2 != null)
            {
                points.Add(actor1.Position);
                points.Add(actor2.Position);
            }
            else if(actor1 != null && useCase1 != null)
            {
                points.Add(actor1.Position);
                points.Add(useCase1.Position);
            }
            else
            {
                points.Add(useCase1.Position);
                points.Add(useCase2.Position);
            }

            return points;
        }


    }
}
