using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TicketModel
    {
        public int HundredPlace
        {
            get; set;
        }

        public int TensPlace
        {
            get; set;
        }

        public int UnitPlace
        {
            get; set;
        }

        public List<int> Leftovers
        {
            get; set;
        }

        public DateTime DrawDate
        {
            get; set;
        }


    }
}
