using System.Collections.Generic;
using WebServiceApi.Data.VO;

namespace WebServiceApi.Business
{
    public interface IScheduleFormsBusiness
    {
        ScheduleFormVO Create(ScheduleFormVO scheduleFormVO);
        ScheduleFormVO FindByID(long id);
        List<ScheduleFormVO> FindByName(string name);
        List<ScheduleFormVO> FindAll();
        ScheduleFormVO Update(ScheduleFormVO scheduleFormVO);
        ScheduleFormVO Disable(long id);
        void Delete(long id);
    }
}
