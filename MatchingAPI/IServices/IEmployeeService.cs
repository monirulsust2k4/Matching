using MatchingAPI.Data.Entity.iBOSDDD;

namespace MatchingAPI.IServices
{
    public interface IEmployeeService
    {
        Task<List<TblUser>> GetUsers(long intAccountId);
    }
}
