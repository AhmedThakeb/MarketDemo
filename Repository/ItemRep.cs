using MarketDemo.Context;
using MarketDemo.Entities;

namespace MarketDemo.Repository
{
    public class ItemRep : IItemRep
    {
		private readonly dbcontainer db;

		public ItemRep(dbcontainer db)
        {
			this.db = db;
		}
        public Items Add(Items Obj)
        {
            db.Items.Add(Obj);
            db.SaveChanges();
            return Obj;
        }

        public Items Delete(int id)
        {
           var OldObj = db.Items.Find(id);
            db.Items.Remove(OldObj);
            db.SaveChanges();
            return OldObj;
        }

        public Items Edit(Items Obj)
        {
            var OldObj = db.Items.Find(Obj.Id);
            OldObj.Name = Obj.Name;
            db.SaveChanges();
            return Obj;
        }

        public IEnumerable<Items> GetAll()
        {
            var data = db.Items.Select(I => I);
            return data;
        }

        public Items GetById(int id)
        {
            var data = db.Items.Find(id);
            return  data;
        }
    }
}
