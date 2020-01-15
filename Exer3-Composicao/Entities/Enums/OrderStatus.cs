using System;
using System.Collections.Generic;
using System.Text;

namespace Exer3_Composicao.Entities
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
