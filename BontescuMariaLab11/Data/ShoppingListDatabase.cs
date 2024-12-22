﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BontescuMariaLab11.Models;

namespace BontescuMariaLab11.Data
{
    public class ShoppingListDatabase
    {
        IRestService restService;

        public ShoppingListDatabase(IRestService service)
        {
            restService = service;

        }

        public Task<List<ShopList>> GetShopListsAsync()
        {
            return restService.RefreshDataAsync();
        }


        public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
        {
            return restService.SaveShopListAsync(item, isNewItem);
        }
        public Task DeleteShopListAsync(ShopList item)
        {
            return restService.DeleteShopListAsync(item.ID);
        }
    }
}
