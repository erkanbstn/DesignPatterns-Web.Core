using Facade.DAL;

namespace Facade.FacadePattern
{
    public class OrderFacade
    {
        Order Order = new Order();
        OrderDetail OrderDetail = new OrderDetail();

        AddOrder _AddOrder;
        AddOrderDetail _AddOrderDetail;
        ProductStock _ProductStock;

        public OrderFacade(AddOrder addOrder, AddOrderDetail addOrderDetail, ProductStock productStock)
        {
            _AddOrder = addOrder;
            _AddOrderDetail = addOrderDetail;
            _ProductStock = productStock;
        }

        public void CompleteOrder(int id, int productId, int orderId, int productCount, decimal productPrice, decimal totalProductPrice)
        {
            Order.CustomerId = id;
            _AddOrder.AddNewOrder(Order);

            OrderDetail.OrderId = orderId;
            OrderDetail.CustomerId = id;
            OrderDetail.ProductId = productId;
            OrderDetail.ProductCount = productCount;
            OrderDetail.ProductPrice = productPrice;
            OrderDetail.TotalProductPrice = productCount * productPrice;
            _AddOrderDetail.AddNewOrderDetail(OrderDetail);

            _ProductStock.StockDecrease(productId, productCount);
        }
    }
}
