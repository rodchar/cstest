using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPRewards2
{
    public class DAL
    {
        public static DataSet GetData()
        {
            //Todo: Remove this from production
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            DataRow dr1 = dt.NewRow();
            DataRow dr2 = dt.NewRow();
            dt.Rows.Add(1, "Charity");
            dt.Rows.Add(2, "Rodney");
            ds.Tables.Add(dt);
            return ds;
            //end todo
        }
    }
}
