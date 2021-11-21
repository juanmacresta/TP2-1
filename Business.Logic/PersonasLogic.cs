using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PersonasLogic : BusinessLogic
    {
        private Data.Database.PersonasAdapter _PersonasData; 

        public PersonasAdapter PersonasData
        {
            get { return _PersonasData; }
            set { _PersonasData = value; }
        }

        public PersonasLogic()
        {
            this.PersonasData = new PersonasAdapter();
        }
        public List<Personas> GetAllP()
        {
            this.PersonasData = new Data.Database.PersonasAdapter();
            return this.PersonasData.GetAllP();
        }
        public List<Personas> GetAllA()
        {
            this.PersonasData = new Data.Database.PersonasAdapter();
            return this.PersonasData.GetAllA();
        }
        public Business.Entities.Personas GetOne(int id)
        {
            this.PersonasData = new Data.Database.PersonasAdapter();
            return PersonasData.GetOne(id);
        }

        public List<Personas> GetAll()
        {
            return PersonasData.GetAll();
        }

        public void Delete(int id)
        {
            this.PersonasData = new Data.Database.PersonasAdapter();
            PersonasData.Delete(id);
        }

        public void Save(Business.Entities.Personas per)
        {
            this.PersonasData = new Data.Database.PersonasAdapter();
            PersonasData.Save(per);
        }
        public Business.Entities.Personas Ult()
        {
            this.PersonasData = new Data.Database.PersonasAdapter();
            return PersonasData.Ult();
        }

    }
}
