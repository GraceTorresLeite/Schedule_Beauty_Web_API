using System.Collections.Generic;
using WebServiceApi.Models;
using WebServiceApi.Repository.Generic;

namespace WebServiceApi.Repository
{
    public interface IScheduleFormRepository : IGenericRepository<ScheduleForm>
    {
        ScheduleForm Disable(long id);
        List<ScheduleForm> findByName(string name);
    }
}
