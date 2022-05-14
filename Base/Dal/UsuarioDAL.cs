using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UsuarioDAL
    {

        public Usuario Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();

            // caso aconteça algum erro , o erro sera tratado abaixo.
            try
            {
                cn.ConnectionString = @"User ID=SA;Initial Catalog=LOJA;Data Source=.; Password=123";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirUsuario";

                SqlParameter patio = new SqlParameter("@Ativo", System.Data.SqlDbType.Bit);
                patio.Value = _usuario.Ativo;
                cmd.Parameters.Add(patio);
                cmd.Parameters.Add(new SqlParameter("@NomeUsuario", System.Data.SqlDbType.VarChar)
                {
                    Value = _usuario.NomeUsuario
                });

                SqlParameter psenha = new SqlParameter("@senha", System.Data.SqlDbType.VarChar);
                psenha.Value = _usuario.Senha;
                cmd.Parameters.Add(psenha);

                SqlParameter pid = new SqlParameter("@id", System.Data.SqlDbType.Int);
                pid.Value = _usuario.Id;
                cmd.Parameters.Add(pid);

                cn.Open();
                _usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _usuario;
            }

            catch (SqlException ex)
            {
                throw new Exception(" Serviço SQL Erro: " + ex.Message);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                cn.Close();
            }
        }



//       .\SQLEXPRESS2019
    }


    

}
