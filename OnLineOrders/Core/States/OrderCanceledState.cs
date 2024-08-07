using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineOrders.Core.States
{
    internal class OrderCanceledState : IOrderState
    {
        private readonly Order _order;
        public OrderCanceledState(Order order) 
        { 
            _order = order; 
        }
        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Confirm()
        {
            throw new NotImplementedException();
        }

        public void Deliver()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            throw new NotImplementedException();
        }

        public void Return()
        {
            throw new NotImplementedException();
        }

        public void Ship()
        {
            throw new NotImplementedException();
        }
    }
}
