using MarketDemo.Context;
using MarketDemo.Entities;

namespace MarketDemo.Repository
{
    public class OrderRep : IOrderRep
    {
		private readonly dbcontainer db;

		public OrderRep(dbcontainer db)
        {
			this.db = db;
		}

        public Orders Add(Orders Obj)
        {
            db.Orders.Add(Obj);
            db.SaveChanges();
            return Obj;
        }
        
        public Orders Delete(Orders id)
        {
            var data = db.Orders.Find(id);
            db.Orders.Remove(data);
            db.SaveChanges();
            return data;
            
        }

        public Orders Edit(Orders Obj)
        {
            var OldObj = db.Items.Find(Obj.Id);
            OldObj.Name = Obj.Name;
            db.SaveChanges();
            return Obj;

        }

        public IEnumerable<Orders> GetAll()
        {
            var data = db.Orders.Select(O => O);
            return data;
        }

        public Orders GetById(int id)
        {
            var data = db.Orders.Find(id);
            return data;    
        }
    }
}
