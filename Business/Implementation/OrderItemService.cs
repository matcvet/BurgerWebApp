using Business.Abstraction;
using ViewModels;
using DomainModels;
using DataAccess.Abstraction;

namespace Business.Implementation
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IRepository<MenuItem> _menuItemRepository;
        private readonly IRepository<Order> _orderRepository;

        public OrderItemService(IRepository<MenuItem> menuItemsRepository, IRepository<Order> ordersRepository)
        {
            _menuItemRepository = menuItemsRepository;
            _orderRepository = ordersRepository;
        }

        public void Save(OrderItemViewModel model)
        {
            if(model.MenuItem == null || model.Quantity <= 0)
            {
                throw new Exception("All fields are required");
            }

            var order = _orderRepository.GetById(model.OrderId);

            if(order == null)
            {
                throw new Exception("Order does not exist");
            }

            var menuItem = _menuItemRepository.GetById(model.MenuItem.Id);

            if(menuItem == null)
            {
                throw new Exception("Menu item does not exist");
            }

            var newOrderItem = new OrderItem(menuItem, model.Quantity);

            order.OrderItems.Add(newOrderItem);

            _orderRepository.Update(order);
        }

        public int Delete(int id)
        {
            var order = _orderRepository.GetById(id);

            if (order == null)
            {
                throw new Exception("Order does not exist");
            }

            var orderItem = order.OrderItems.FirstOrDefault(x => x.Id == id);

            order.OrderItems.Remove(orderItem);

            _orderRepository.Update(order);

            return order.Id;
        }
    }
}
