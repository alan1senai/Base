using System.Collections.Generic;
using System.Data.SqlClient;

namespace Dal
{
    public class Banco
    {
        readonly SqlTransaction t = null;
        readonly SqlConnection cn = null;

        public Banco()
        {
            t = cn.BeginTransaction(System.Data.IsolationLevel.Serializable);
            cn = new SqlConnection("");


        }
        public bool ExecutarComando(List<ComandoSQL>cmd)
        {

            foreach (var item in cmd)
            {
                item.Comando.Transaction = t;

                foreach (var p in item.Parametros)
                {
                    item.Comando.Parameters.AddWithValue(p.Parametro, p.Valor);

                }
                item.Comando.ExecuteNonQuery();
                
               


            }
            t.Commit(); 
            return true;
        }
            


    }
}
