﻿using MarketDemo.Entities;

namespace MarketDemo.Contracts
{
    public interface ICustomerRep
    {
        IEnumerable<Customers> GetAll();
        Customers GetById(int id);
        Customers AddObj(Customers Obj);
        Customers EditObj(Customers Obj);
        Customers DeleteObj(int id);
    }
}
