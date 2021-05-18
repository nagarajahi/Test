using JewelryApiService.EFModels.DB;
using JewelryApiService.Models;
using System.Threading.Tasks;

namespace JewelryApiService.DAL.Interfaces
{
    public interface iUserAccountDAL
    {
        Task<string> UserLogin(User user);

    }
}
