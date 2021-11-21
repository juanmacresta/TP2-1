using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        private int _cargo;
        private int _idCurso;
        private int _idDocente;

        public int Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }
        public int IdCurso 
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }
        public int IdDocente 
        {
            get { return _idDocente; }
            set { _idDocente = value; }
        }
    }
}