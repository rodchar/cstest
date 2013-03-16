using System;
using System.Data;
using System.Windows.Forms;

namespace BPRewards2
{
    public partial class ucListView : UserControl
    {
        public event EventHandler UserControlClicked;
        public DataRowView DataRowViewSelected { get; set; }

        public ucListView()
        {
            InitializeComponent();
        }

        public void UserControlClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Like double clicking column's auto width
            {
                DataRowViewSelected = ((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem); //["Name"]
                //Raise event
                if (UserControlClicked != null) UserControlClicked(sender, e);
            }
        }
    }
}
