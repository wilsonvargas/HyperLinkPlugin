﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestAppHyperLinkControl.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);

        Task<bool> DeleteItemAsync(T item);

        Task<T> GetItemAsync(string id);

        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);

        Task<bool> UpdateItemAsync(T item);
    }
}
