using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();

        AddOrder addOrder= new AddOrder();
        AddOrderDetail addOrderDetail= new AddOrderDetail();


        /// <summary>
        /// Bu metotdumuz sayesinde tüm sipariş sürecini tek bir metot üzerinden yürütüyoruz.Gerekli atamaları bunun içerisinden yapıyoruz.
        /// </summary>

        public void CompleteOrderDetail(int customerID,int productID,int orderID,int productCount,decimal productPrice)
        {
            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);

            orderDetail.OrderID = orderID;
            orderDetail.CustomerID = customerID;
            orderDetail.ProductID = productID;
            orderDetail.ProductPrice = productPrice;
            orderDetail.ProductCount = productCount;
            decimal totalProductPrice = productCount * productPrice;
            orderDetail.ProductTotalPrice = totalProductPrice;

            addOrderDetail.AddNewOrderDetail(orderDetail);

            productStock.DecreaseStock(productID, productCount);

        }

        public void ComplateOrder(int customerID)
        {
            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);

        }

    }
}
