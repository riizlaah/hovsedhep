using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HovSedhep.Models
{
    public class TableView
    {
        public int TransacId { get; set; }
        public Transaction Transac { get; set; }
        public string Name { get; set; }
        public string CustomerName { get; set; }
        public Employee Employee { get; set; }
        public int PaxSize { get; set; }
    }
}
