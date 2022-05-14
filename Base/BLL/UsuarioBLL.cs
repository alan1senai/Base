using Dal;
using Model;
using System.Collections.Generic;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario usuario)
        {
            
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(usuario);
                       

        }
        public void Excluir()
        {

        }
        public void Alterar()
        {

        }
        public List<Usuario> Buscar()
        {
            return new List<Usuario>();
        }
    }
}