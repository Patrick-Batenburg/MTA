using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPubSub
{
    class Rectangle
    {
        public event EventHandler Changed;
        private double length;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = 5;
                Changed(this, EventArgs.Empty);
            }
        }
    }
}
