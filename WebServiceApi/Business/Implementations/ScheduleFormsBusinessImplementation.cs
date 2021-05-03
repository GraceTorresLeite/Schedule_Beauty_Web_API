using System.Collections.Generic;
using WebServiceApi.Data.Converter.Implementations;
using WebServiceApi.Data.VO;
using WebServiceApi.Repository;

namespace WebServiceApi.Business.Implementations
{
    public class ScheduleFormsBusinessImplementation : IScheduleFormsBusiness
    {
        private readonly IScheduleFormRepository _repository;
        private readonly ScheduleFormConverter _converter;
        public ScheduleFormsBusinessImplementation(IScheduleFormRepository repository)
        {
            _repository = repository;
            _converter = new ScheduleFormConverter();
        }

        public ScheduleFormVO Create(ScheduleFormVO ScheduleFormVO)
        {
            var scheduleFormEntity = _converter.Parse(ScheduleFormVO);
            scheduleFormEntity = _repository.Create(scheduleFormEntity);
            return _converter.Parse(scheduleFormEntity);
        }

        public ScheduleFormVO Disable(long id)
        {
            var scheduleFormEntity = _repository.Disable(id);
            return _converter.Parse(scheduleFormEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<ScheduleFormVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public ScheduleFormVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public List<ScheduleFormVO> FindByName(string name)
        {
            return _converter.Parse(_repository.findByName(name));
        }

        public ScheduleFormVO Update(ScheduleFormVO ScheduleFormVO)
        {
            var scheduleFormEntity = _converter.Parse(ScheduleFormVO);
            scheduleFormEntity = _repository.Update(scheduleFormEntity);
            return _converter.Parse(scheduleFormEntity);
        }
    }
}
