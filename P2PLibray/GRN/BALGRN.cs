using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2PHelper;

namespace P2PLibray.GRN
{

   
    public class BALGRN
    {

        MSSQL objsql = new MSSQL();

        public async Task<SqlDataReader> GetReturnGoods()
        {
            Dictionary<String, String> param = new Dictionary<String, String>();
            param.Add("@flag", "GSTtblGoodsReturnHSB");
            SqlDataReader dr = await objsql.ExecuteStoredProcedureReturnDataReader("GRNProcedure", param);

            return dr;

        }





    }
}
