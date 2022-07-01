using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ShopingCartRepository : Repository<ShoppingCart>, IShopingCartRepository
    {
        private ApplicationDbContext _db;

        public ShopingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public int DecrementCount(ShoppingCart shoppinhCart, int count)
        {
            shoppinhCart.Count -= count;
            return shoppinhCart.Count;
        }

        public int IncrementCount(ShoppingCart shoppinhCart, int count)
        {
            shoppinhCart.Count += count;
            return shoppinhCart.Count;
        }
    }
}
