﻿using ecom.Models;

namespace ecom.Repository
{
    public interface IWishListRepository
    {
        List<WishList> GetAll();

        WishList GetById(int id);

        void Insert(WishList obj);

        void Update(WishList obj);

        void Delete(int id);

        void Save();
        public List<WishList> GetAllbyCustomerId(string id);
    }
}