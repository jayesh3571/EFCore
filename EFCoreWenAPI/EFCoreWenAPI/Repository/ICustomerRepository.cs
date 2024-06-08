using EFCoreWenAPI.Models;

namespace EFCoreWenAPI.Repository
{
    public interface ICustomerRepository
    {
        //This method returns all the Employee entities as an enumerable collection
        Task<IEnumerable<Customer>> GetAllAsync();
        //This method accepts an integer parameter representing an Employee ID and
        //returns a single Employee entity matching that Employee ID.
        Task<Customer?> GetByIdAsync(int id);
        //This method accepts an Employee object as the parameter and
        //adds that Employee object to the Employees DbSet.
        //mark the entity state as Added
        Task InsertAsync(Customer customer);
        //This method accepts an Employee object as a parameter and
        //marks that Employee object as a modified Employee in the DbSet.
        Task UpdateAsync(Customer customer);
        //This method accepts an EmployeeID as a parameter and
        //removes that Employee entity from the Employees DbSet.
        //Mark the Entity state as Deleted
        Task DeleteAsync(int id);
        //This method Saves changes to the EFCoreDb database.
        Task SaveAsync();
    }
}
