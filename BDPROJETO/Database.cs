using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace BDPROJETO
{
    public static class Database
    {

        static FbConnection _conexaoFB;

        public static FbConnection conexao
        {
            get
            {
                return _conexaoFB;

            }

        }

        public static bool Conectar()
        {
            string strConexao;

            string localdb;

            localdb = "Database=C:\\Users\\paccola\\Documents\\Visual Studio 2017\\Projects\\BDPROJETO\\MINIMUNDONAVIOS.FDB;";

            strConexao = "User=SYSDBA;" + "Password=masterkey;" + localdb
                + "Port=3050;" + "Dialect=3;" + "Charset=NONE;" + "Role=;" + "Connection timeout=7;" + "Connection lifetime=0;" + "Pooling=true;"
                + "Pocket Size=8192;" + "Server Type=0";

            _conexaoFB = new FbConnection(strConexao);
            _conexaoFB.Open();

            return true;

        }

        public static bool Desconectar()
        {

            _conexaoFB.Close();
            _conexaoFB = null;

            return true;

        }



    }
}
