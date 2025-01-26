using MatchingAPI.Data;
using MatchingAPI.Data.Entity;
using MatchingAPI.IServices;
using Microsoft.EntityFrameworkCore;

namespace MatchingAPI.Services.SignalR
{
    public class NotificationService : INotificationService
    {
        //private readonly PeopleDeskContext _context;
        //private readonly iBOSDDDbContext _iBOSDDDContext;

        private readonly PeopleDeskContext _context;
        private readonly iBOSDDDbContext _iBOSDDDContext;
        //public EmployeeService(iBOSDDDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public NotificationService(PeopleDeskContext context)
        {
            _context = context;
        }

        public async Task<long> SaveNotificationMaster(NotificationMaster obj)
        {
            try
            {
                if (obj.IntId > 0)
                {
                    _context.NotificationMasters.Update(obj);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    await _context.NotificationMasters.AddAsync(obj);
                    await _context.SaveChangesAsync();
                }

                return obj.IntId;
            }
            catch (Exception)
            {
                return -999;
            }
        }


        public async Task<IEnumerable<NotificationMaster>> GetNotificationCount(long employeeId, long accountId)
        {
            try
            {
                var data = await (from m in _context.NotificationMasters
                                  where m.IsActive == true && m.IntOrgId == accountId
                                  && (m.IsCommon == false && !string.IsNullOrEmpty(m.StrReceiver) ? m.StrReceiver == employeeId.ToString() && m.IsSeen == false
                                     : m.IsCommon == true ? _context.NotificationDetails.Where(x => x.IntMasterId == m.IntId && x.StrReceiver == employeeId.ToString()).Count() <= 0
                                     : false)
                                  select m).Distinct().AsQueryable().AsNoTracking().ToListAsync();
               
                return data;
            }
            catch (Exception e)
            {
                throw new Exception("invalid data");
            }
        }
    }
}
