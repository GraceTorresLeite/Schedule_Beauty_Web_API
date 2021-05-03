using System.Collections.Generic;
using System.Linq;
using WebServiceApi.Data.Converter.Contract;
using WebServiceApi.Data.VO;
using WebServiceApi.Models;

namespace WebServiceApi.Data.Converter.Implementations
{
    public class ScheduleFormConverter : IParser<ScheduleFormVO, ScheduleForm>, IParser<ScheduleForm, ScheduleFormVO>
    {
        public ScheduleForm Parse(ScheduleFormVO origin)
        {
            if (origin == null)
            {
                return null;
            }
            return new ScheduleForm
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Email = origin.Email,
                Address = origin.Address,
                Phone = origin.Phone,
                Service = origin.Service,
                Date = origin.Date
            };
        }

        public ScheduleFormVO Parse(ScheduleForm origin)
        {
            if (origin == null)
            {
                return null;
            }
            return new ScheduleFormVO
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Email = origin.Email,
                Address = origin.Address,
                Phone = origin.Phone,
                Service = origin.Service,
                Date = origin.Date
            };
        }
        public List<ScheduleForm> Parse(List<ScheduleFormVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
        public List<ScheduleFormVO> Parse(List<ScheduleForm> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
