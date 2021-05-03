using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceApi.Models;
using WebServiceApi.Models.Bd;
using WebServiceApi.Repository.Generic;

namespace WebServiceApi.Repository
{
    public class ScheduleFormRepository : GenericRepositoryImplementation<ScheduleForm>, IScheduleFormRepository
    {
        public ScheduleFormRepository(ContextSql context) : base(context) { }
        public ScheduleForm Disable(long id)
        {
            if (!_context.SchedulesForms.Any(schedule => schedule.Id.Equals(id))) return null;
            var user = _context.SchedulesForms.SingleOrDefault(scheduleForm => scheduleForm.Id.Equals(id));
            if (user != null)
            {
                user.Enabled = false;
                try
                {
                    _context.Entry(user).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return user;
        }

        public List<ScheduleForm> findByName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return _context.SchedulesForms.Where(
                schedule => schedule.FirstName.Contains(name)).ToList();
            }

            return null;
        }
    }
}

