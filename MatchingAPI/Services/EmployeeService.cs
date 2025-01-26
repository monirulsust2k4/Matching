using MatchingAPI.Data;
using MatchingAPI.Data.Entity.iBOSDDD;
using MatchingAPI.IServices;
using Microsoft.EntityFrameworkCore;

namespace MatchingAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly iBOSDDDbContext _dbContext;
        public EmployeeService(iBOSDDDbContext dbContext)
        {
            _dbContext= dbContext;
        }
        public async Task<List<TblUser>> GetUsers(long intAccountId)
        {
            var result =await _dbContext.TblUsers
                            .Where(x=>x.IntAccountId== intAccountId)
                            .Take(10)
                            .ToListAsync();
            return result;  
        }
    }
}
