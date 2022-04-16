using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_GENERATE_EVENTHANLDER
{
    public class PersonEventArgs : EventArgs
    {
        public PersonEventArgs() : base()
        {
        }

        public int PersonId { get; set; }
    }
}
