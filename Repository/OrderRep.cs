using MarketDemo.Context;
using MarketDemo.Entities;

namespace MarketDemo.Repository
{
    public class OrderRep : IOrderRep
    {
        dbcontainer db = new dbcontainer();
       
        public Orders Add(Orders Obj)
        {
            db.Order.Add(Obj);
            db.SaveChanges();
            return Obj;
        }
        
        public Orders Delete(Orders id)
        {
            var data = db.Order.Find(id);
            db.Order.Remove(data);
            db.SaveChanges();
            return data;
            
        }

        public Orders Edit(Orders Obj)
        {
            var OldObj = db.Item.Find(Obj.Id);
            OldObj.Name = Obj.Name;
            db.SaveChanges();
            return Obj;

        }

        public IEnumerable<Orders> GetAll()
        {
            var data = db.Order.Select(O => O);
            return data;
        }

        public Orders GetById(int id)
        {
            var data = db.Order.Find(id);
            return data;    
        }
    }
}
