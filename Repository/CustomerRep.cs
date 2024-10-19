using MarketDemo.Context;
using MarketDemo.Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MarketDemo.Repository
{
    public class CustomerRep : ICustomerRep
    {
        dbcontainer db = new dbcontainer();
        public Customers AddObj(Customers Obj)
        {
           var data = db.Customer.Add(Obj);
            db.SaveChanges();
            return Obj;
        }

        public Customers DeleteObj(int id)
        {
           var OldObj = db.Customer.Find(id);
            db.Customer.Remove(OldObj);
            db.SaveChanges();
            return OldObj;

        }

        public Customers EditObj(Customers Obj)
        {
            var OldObj = db.Customer.Find(Obj);
            OldObj.Name = Obj.Name;
            db.SaveChanges();
            return Obj;

        }

        public IEnumerable<Customers> GetAll()
        {
            var data = db.Customer.Select(C => C);
            return data;
        }

        public Customers GetById(int id)
        {
           var data = db.Customer.Find(id);
            return data;
        }
    }
}
