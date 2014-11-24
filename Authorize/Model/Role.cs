using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual List<Function> Functions { get; set; }
        public virtual List<Role> Roles { get; set; }
    }
}
