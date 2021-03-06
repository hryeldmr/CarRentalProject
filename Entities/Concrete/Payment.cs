using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }       
        public string CartName { get; set; }
        public string CartNumber { get; set; }
        public string CartDate { get; set; }
        public short CartCvv { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
