using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineOrders.Core.States
{
    internal class OrderConfirmedState : IOrderState
    {
        private readonly Order _order;

        public OrderConfirmedState(Order order)
        {
            _order = order;   
        }
        public void Cancel()
        {
           _order.State = new OrderCanceledState(_order);
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
            _order.State = new OrderProcessedState(_order);
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
