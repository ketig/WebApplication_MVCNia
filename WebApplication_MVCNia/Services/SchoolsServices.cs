using WebApplication_MVCNia.Contracts;
using WebApplication_MVCNia.Data;
using WebApplication_MVCNia.Models.Entities;

namespace WebApplication_MVCNia.Services
{
    public class SchoolsServices : ISchoolsServices
    {
        private readonly SchoolsContext context;

        public SchoolsServices(SchoolsContext schoolsContext)
        {
            this.context = schoolsContext;
        }

        public async Task CreateAsync(School school)
        {
            await context.AddAsync(school);
            await context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var school = await ReadByIdAsync(id);

            if (school != null)
            {
                context.Schools.Remove(school);
                await context.SaveChangesAsync();
            }
        }

        public Task<IEnumerable<School>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<School?> ReadByIdAsync(int id)
        {
            return await context.Schools.FindAsync(id);
        }

        public Task UpdateAsync(School school)
        {
            throw new NotImplementedException();
        }
    }
}
