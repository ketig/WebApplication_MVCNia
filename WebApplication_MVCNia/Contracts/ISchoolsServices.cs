using WebApplication_MVCNia.Models.Entities;

namespace WebApplication_MVCNia.Contracts;

public interface ISchoolsServices
{
    Task CreateAsync(School school);

    Task<School?> ReadByIdAsync(int id);

    Task<IEnumerable<School>> ReadAllAsync();

    Task DeleteByIdAsync(int id);

    Task UpdateAsync(School school);
}
