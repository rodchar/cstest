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
        public static DataTable GetData()
        {
            //Todo: Remove this from production
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            DataRow dr1 = dt.NewRow();
            DataRow dr2 = dt.NewRow();
            dt.Rows.Add(1, "Charity");
            dt.Rows.Add(2, "Rodney");
            return dt;
            //end todo
        }

        public static DataTable GetData2()
        {
            //Todo: Remove this from production
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            DataRow dr1 = dt.NewRow();
            DataRow dr2 = dt.NewRow();
            dt.Rows.Add(4, "Carey");
            dt.Rows.Add(5, "Katie-Scarlet");
            dt.Rows.Add(6, "Thomas-James");
            return dt;
            //end todo
        }

        public static DataTable GetProducts()
        {
            //Todo: Remove this from production
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            DataRow dr1 = dt.NewRow();
            DataRow dr2 = dt.NewRow();
            dt.Rows.Add(1, "Product1");
            dt.Rows.Add(2, "Product2");
            dt.Rows.Add(3, "Product3");
            return dt;
            //end todo
        }

        public static DataTable GetCategories()
        {
            //Todo: Remove this from production
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryId", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(1, "Category1");
            dt.Rows.Add(2, "Category2");
            dt.Rows.Add(3, "Category3");
            return dt;
            //end todo
        }

        public static DataTable GetProductRequirements()
        {
            //Todo: Remove this from production
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryId", typeof(int));
            dt.Columns.Add("ProductId", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Rows.Add(null, 1, "Product1", 2);
            dt.Rows.Add(2,null, "Category2",1);
            dt.Rows.Add(6, "Thomas-James");
            return dt;
            //end todo
        }
    }
}
