using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Domain.Core.Aggregates
{
    public class Order : EntityBase, IAggregateRoot
    {
        public Guid Transaction { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        protected virtual ICollection<LineOrder> Lines { get; set; }

        public void AddLineOrder(LineOrder lineOrder)
        {
            Lines.Add(lineOrder);
        }
    }
}
