using DataAccess.Abstraction;
using DomainModels;

namespace DataAccess.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly BurgerAppDbContext _DbContext;

        public OrderRepository(BurgerAppDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public List<Order> GetAll()
        {
            return _DbContext.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _DbContext.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Order entity)
        {
            _DbContext.Orders.Add(entity);
            _DbContext.SaveChanges();
        }

        public void Update(Order entity)
        {
            var item = GetById(entity.Id);

            if(item != null)
            {
                _DbContext.Orders.Update(item);
                _DbContext.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            var item = GetById(id);

            if(item != null)
            {
                _DbContext.Orders.Remove(item);
                _DbContext.SaveChanges();
            }
        }
    }
}
