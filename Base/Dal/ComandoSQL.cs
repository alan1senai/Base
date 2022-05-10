using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ComandoSQL
    {

        private SqlCommand comando;

        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }



        private List <ParametroSQL>parametros;



        public List<ParametroSQL> Parametros
        {
            get { return parametros; }
            set { parametros = value; }
        }




    }
}
