using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class DocenteCursoLogic:BusinessLogic
    {
        private Data.Database.DocenteCursoAdapter _DocenteCurso;

        public DocenteCursoAdapter DocenteCurso { get => _DocenteCurso; set => _DocenteCurso = value; }
        public DocenteCursoLogic()
        {

        }
        public DocenteCursoLogic(Data.Database.DocenteCursoAdapter x)
        {
            this.DocenteCurso = x;
        }
        public List<DocenteCurso> GetAll()
        {
            this.DocenteCurso = new Data.Database.DocenteCursoAdapter();
            return this.DocenteCurso.GetAll();
        }
        public Business.Entities.DocenteCurso GetOne(int ID)
        {
            this.DocenteCurso = new Data.Database.DocenteCursoAdapter();
            return DocenteCurso.GetOne(ID);
        }
        public void Delete(int ID)
        {
            DocenteCurso.Delete(ID);
        }
        public void Save(Business.Entities.DocenteCurso dc)
        {
            this.DocenteCurso = new Data.Database.DocenteCursoAdapter();
            DocenteCurso.Save(dc);
        }

    }
}
