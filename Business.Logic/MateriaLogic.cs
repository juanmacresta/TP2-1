using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class MateriaLogic : BusinessLogic
    {
        private Data.Database.MateriasAdapter _MateriaData;

        public MateriasAdapter MateriaData
        {
            get { return _MateriaData; }
            set { _MateriaData = value; }
        }

        public MateriaLogic()
        {
            this.MateriaData = new MateriasAdapter();
        }

        public Business.Entities.Materia GetOne(int id)
        {
            return MateriaData.GetOne(id);
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }

        public void Delete(int id)
        {
            MateriaData.Delete(id);
        }

        public void Save(Business.Entities.Materia mat)
        {
            MateriaData.Save(mat);
        }
    }
}
