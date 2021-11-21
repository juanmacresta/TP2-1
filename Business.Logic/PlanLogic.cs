using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PlanLogic:BusinessLogic
    {
        private Data.Database.PlanAdapter _PlanAdapter;
        public Data.Database.PlanAdapter PlanData
        {
            get => _PlanAdapter;
            set => _PlanAdapter = value;
        }
        public PlanLogic(Data.Database.PlanAdapter x)
        {
            PlanData = x;
        }

        public PlanLogic()
        {

        }

        public List<Plan> GetAll()
        {

            this.PlanData = new Data.Database.PlanAdapter();
            return PlanData.GetAll();
        }

        public Business.Entities.Plan GetOne(int ID)
        {
            this.PlanData = new Data.Database.PlanAdapter();
            return PlanData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            this.PlanData = new Data.Database.PlanAdapter();
            PlanData.Delete(ID);
        }

        public void Save(Business.Entities.Plan plan)
        {
            this.PlanData = new Data.Database.PlanAdapter();
            PlanData.Save(plan);
        }
        public bool ExisteEspecialidad(int ID)
        {
            EspecialidadLogic espe = new EspecialidadLogic();
            espe.EspecialidadData = new Data.Database.EspecialidadesAdapter();
            return espe.EspecialidadData.ExisteEspecialidad(ID);
        }
    }
}
