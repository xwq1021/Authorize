using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Function
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int ControlID { get; set; }
        public string IconImage { get;set; }

        public virtual List<OU> OUs { get; set; }
        public virtual List<Role> Roles { get; set; }
    }
}
