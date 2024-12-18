﻿using MarketDemo.Entities;

namespace MarketDemo.Contracts
{
    public interface IOrderRep
    {
        IEnumerable<Orders> GetAll();
        Orders GetById(int id);
        Orders Add(Orders Obj);
        Orders Edit(Orders Obj);
        Orders Delete(Orders id);
    }
}
