using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OU
    {
        public int ID { get; set; }
        public int PID { get; set; }
        public bool Position { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }

        public virtual List<Function> Functions { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
