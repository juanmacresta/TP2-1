using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class EspecialidadLogic : BusinessLogic
    {
        private Data.Database.EspecialidadesAdapter _EspecialidadData;

        public EspecialidadesAdapter EspecialidadData
        {
            get { return _EspecialidadData; }
            set { _EspecialidadData = value; }
        }

        public EspecialidadLogic()
        {
            this._EspecialidadData = new EspecialidadesAdapter();
        }

        public Business.Entities.Especialidad GetOne(int id)
        {
            return EspecialidadData.GetOne(id);
        }

        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }

        public void Delete(int id)
        {
            EspecialidadData.Delete(id);
        }

        public void Save(Business.Entities.Especialidad esp)
        {
            EspecialidadData.Save(esp);
        }
    }
}
