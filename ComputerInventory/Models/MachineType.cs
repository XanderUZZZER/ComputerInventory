using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInventory.Models
{
    public partial class MachineType
    {
        public int MachineTypeId { get; set; }
        public string Description { get; set; }
        public ICollection<Machine> Machine { get; set; }

        public MachineType()
        {
            Machine = new HashSet<Machine>();
        }
    }
}
