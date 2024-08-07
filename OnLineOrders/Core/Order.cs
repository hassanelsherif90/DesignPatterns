using OnLineOrders.Core.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineOrders.Core
{
    internal class Order
    {
        public Order() 
        {
            State = new OrderDraftState(this);
        }
        public IOrderState State { get; internal set; }

        public List<OrderLines> Lines = new();
        /* public void SetState(OrderState newState)
         {
             if (
                     (State == OrderState.Draft && newState != OrderState.Confirmed) ||
                     (State == OrderState.Confirmed && newState != OrderState.Canceled && newState != OrderState.UnderProcessing) ||
                     (State == OrderState.UnderProcessing && newState != OrderState.Shipped) ||
                     (State == OrderState.Shipped && newState != OrderState.Delivered)||
                     (State == OrderState.Delivered && newState != OrderState.Returned)

                )
                 throw new InvalidCastException($"Moving from State '{State}'to state '{newState}' is not support");
             else
                 State = newState;   
         }*/
       
        public void Confirm()
        {
            State.Confirm();
        }
        public void Cancel()
        {
            State.Cancel();
        }
        public void Process()
        {
            State.Process();    
        }
        public void Ship()
        {
            State.Ship();   
        }
        public void Deliver()
        {
            State.Deliver();
        }
        public void Return()
        {
            State.Return(); 
        }
    }
}
