using DomainModels;
using ViewModels;

namespace Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToViewModel(this Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                PhoneNumber = order.PhoneNumber,
                Address = order.Address,
                Note = order.Note,
                TotalPrice = order.TotalPrice,
                Items = order.OrderItems.Select(x => x.ToViewModel()).ToList()
            };
        }
    }
}
