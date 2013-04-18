using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ucListView : UserControl
    {
        public event EventHandler DataGridViewCellDoubleClickEvent;
        public DataRowView DataRowViewSelected { get; set; }
        public DataTable DataSource { get; set; }


        public ucListView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Like double clicking column's auto width
            {
                DataRowViewSelected = ((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem); //["Name"]
                //Raise event
                if (DataGridViewCellDoubleClickEvent != null) DataGridViewCellDoubleClickEvent(sender, e);
            }
        }

    }
}
