using CrusherSoftwareAPI.Models;
using CrusherSoftwareAPI.DTO;

namespace CrusherSoftwareAPI.IRepository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(int id);
        Task<IEnumerable<CommonDDL>> GetCustomerName();
        Task<IEnumerable<CommonDDL>> GetCityName();
    }
}
