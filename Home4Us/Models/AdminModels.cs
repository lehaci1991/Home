using Home4Us_Models;
using Home4Us_Models.Models.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home4Us.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public string UserDetails { get; set; }
        public PropertyState? PropertyState { get; set; }

        public OrderDetails(Orders order)
        {
            OrderId = (order?.ID).GetValueOrDefault();
            UserDetails = $"{order?.Users?.FirstName} {order?.Users?.LastName} {order?.Users?.Email}";
        }
    }

    public class OrdersDetails
    {
       public List<OrderDetails> Details { get; set; }

        public OrdersDetails(IEnumerable<Orders> orders)
        {
            Details = orders.Select(o => new OrderDetails(o)).ToList();
        }
    }
}