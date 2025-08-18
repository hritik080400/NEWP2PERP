using P2PHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2PLibray
{
    public class BALP2P
    {

        MSSQL objSql = new MSSQL();

        public async Task<DataSet> DisplayItemList()
        {
            Dictionary<String, String> param = new Dictionary<String, String>();
            param.Add("@Flag", "ListRegister");

            DataSet ds = await objSql.ExecuteStoredProcedureReturnDS("RegsterUser", param);

            return ds;

        } 

    }
}
