using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajans_X.classes
{
    class Projects
    {
        public int Id { get; set; }
        public string PrjName { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public float Price { get; set; }

        public Workers Inwork { get; set; }

    }
}
