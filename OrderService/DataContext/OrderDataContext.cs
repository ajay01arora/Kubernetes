using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.DataContext
{
    public class OrderDataContext
    {
        private static Dictionary<int, Order> orderList;
        private static int orderCount = 0;

        static OrderDataContext()
        {
            orderList = new Dictionary<int, Order>();
            orderList.Add(++orderCount, new Order() { orderId = orderCount,  UserId = 1,orderAmount=150, orderDate="11-March-2020"});
            orderList.Add(++orderCount, new Order() { orderId = orderCount, UserId = 2, orderAmount = 120, orderDate = "12-March-2020" });
            orderList.Add(++orderCount, new Order() { orderId = orderCount,  UserId =1, orderAmount = 140, orderDate = "13-March-2020" });
            orderList.Add(++orderCount, new Order() { orderId = orderCount, UserId = 2, orderAmount = 180, orderDate = "15-March-2020" });
        }


        internal static IEnumerable<Order> GetOrderList()
        {
            return orderList.Values.ToList();
        }

        internal static IEnumerable<Order> GetOrderItemByUserId(int userId)
        {
            return orderList.Values.Where(order => order.UserId == userId);
        }
    }
}
