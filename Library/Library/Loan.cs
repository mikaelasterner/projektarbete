using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Loan
    {
        public int Id { get; set; }
        public DateTime Time {get; set;}
        public Member Loaner { get; private set; }
        public Loan(Member loaner) { 
            Loaner = loaner; 
            Time = System.DateTime.Now; 
        }
    }
}
