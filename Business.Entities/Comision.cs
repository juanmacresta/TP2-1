using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private int _anioEspecialidad;
        private string _descripcion;
        private int _idPlan;

        public int AnioEspecialidad 
        {
            get { return _anioEspecialidad; }
            set { _anioEspecialidad = value; }
        }
        public string Descripcion 
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public int IdPlan 
        {
            get { return _idPlan; }
            set { _idPlan = value; }
        }
    }
}