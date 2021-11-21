using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic:BusinessLogic
    {
        private Data.Database.UsuarioAdapter _usuarioData;

        public UsuarioLogic()
        {
            this.UsuarioData = new UsuarioAdapter();
        }

        public UsuarioAdapter UsuarioData 
        {
            get { return _usuarioData; }
            set { _usuarioData = value; }
        }

        public Business.Entities.Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public Business.Entities.Usuario GetOneP(int id)
        {
            return UsuarioData.GetOneP(id);
        }
        public bool GetOne(string nombreUsuario, string contra)
        {
            this.UsuarioData = new Data.Database.UsuarioAdapter();
            return UsuarioData.GetOne(nombreUsuario, contra);
        }
        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }

        public void Save(Business.Entities.Usuario usuario)
        {
            this.UsuarioData = new Data.Database.UsuarioAdapter();
            UsuarioData.Save(usuario);
        }
        public Usuario FindOne(string usu, string pass)
        {
            this.UsuarioData = new Data.Database.UsuarioAdapter();
            return UsuarioData.FindOne(usu, pass);
        }
    }
}
