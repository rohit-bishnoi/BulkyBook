using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IShopingCartRepository : IRepository<ShoppingCart>
    {
        int IncrementCount(ShoppingCart shoppinhCart, int count);
        int DecrementCount(ShoppingCart shoppinhCart, int count);
    }
}
