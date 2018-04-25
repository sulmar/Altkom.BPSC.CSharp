using BPSC.CSharp.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPSC.CSharp.Shop.IServices
{
    public interface IOrdersService
    {
        void Add(Order order);
        Order Get(int id);
        List<Order> Get();
    }
}
