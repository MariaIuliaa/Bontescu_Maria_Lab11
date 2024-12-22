using System.Collections.Generic;
using System.Threading.Tasks;
using BontescuMariaLab11.Models;

namespace BontescuMariaLab11.Data
{
    public interface IRestService
    {
        
        Task<List<ShopList>> RefreshDataAsync();

        Task SaveShopListAsync(ShopList item, bool isNewItem);

        Task DeleteShopListAsync(int id);

    }
}
