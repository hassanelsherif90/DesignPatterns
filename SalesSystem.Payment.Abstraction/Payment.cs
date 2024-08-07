using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payment.Abstraction
{
    public class Payment
    {
        public int CustomerId {  get; set; }    
        public double ChargeAmount {  get; set; }   
        public Guid ReferenceNumber {  get; set; }  

    }
}
