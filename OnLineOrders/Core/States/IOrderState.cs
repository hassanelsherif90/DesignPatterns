using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineOrders.Core.States
{
    internal interface IOrderState
    {
        void Confirm();
        void Cancel();
        void Process();
        void Ship();
        void Deliver();
        void Return();
    }
}
