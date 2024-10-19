using MarketDemo.Context;
using MarketDemo.Entities;

namespace MarketDemo.Repository
{
    public class ItemRep : IItemRep
    {
        dbcontainer db = new dbcontainer();
        public Items Add(Items Obj)
        {
            db.Item.Add(Obj);
            db.SaveChanges();
            return Obj;
        }

        public Items Delete(int id)
        {
           var OldObj = db.Item.Find(id);
            db.Item.Remove(OldObj);
            db.SaveChanges();
            return OldObj;
        }

        public Items Edit(Items Obj)
        {
            var OldObj = db.Item.Find(Obj.Id);
            OldObj.Name = Obj.Name;
            db.SaveChanges();
            return Obj;
        }

        public IEnumerable<Items> GetAll()
        {
            var data = db.Item.Select(I => I);
            return data;
        }

        public Items GetById(int id)
        {
            var data = db.Item.Find(id);
            return  data;
        }
    }
}
