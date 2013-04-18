using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ucListView _lvSpinner1;
        ucDetailView _dvSpinner1;

        public Form1()
        {
            InitializeComponent();
            LoadSpinnerList();
        }

        private void tbApiCalls_Click(object sender, EventArgs e)
        {

        }

        private void tpSpinner_Click(object sender, EventArgs e)
        {

        }

        private void tpRewards_Click(object sender, EventArgs e)
        {
            //Need check
            LoadSpinnerList();
        }

        private void tpCustomers_Click(object sender, EventArgs e)
        {

        }

        private void LoadSpinnerList()
        {
            if (_lvSpinner1 == null)
            {
                _lvSpinner1 = new ucListView();
                tpSpinner.Controls.Add((_lvSpinner1));
                _lvSpinner1.DataGridViewCellDoubleClickEvent += ListViewClickEventHandler_lvSpinner1;
                _lvSpinner1.dataGridView1.DataSource = BLL.GetData2();
            }

        }

        void ListViewClickEventHandler_lvSpinner1(object sender, EventArgs e)
        {
            //This event means a row was selected by double-click
            if (e.GetType().Name == "DataGridViewCellEventArgs")
            {
                _lvSpinner1.Visible = false;
                if (_dvSpinner1 == null)
                {
                    _dvSpinner1 = new ucDetailView();
                    //Todo: Load detail view from database
                    MessageBox.Show("Todo: Load data from db");

                    tpSpinner.Controls.Add(_dvSpinner1);
                    _dvSpinner1.DetailClickEvent += DetailClickEventHandler_dvSpinner1;
                }
                else
                {
                    //Todo: Reload existing detail view from database
                    //  because she could have hit cancel on detail view.
                    MessageBox.Show("Todo: Reload data from db");

                    _dvSpinner1.Visible = !_lvSpinner1.Visible;
                }

            }
        }

        void DetailClickEventHandler_dvSpinner1(object sender, EventArgs e)
        {
            String btnId = (sender as Button).Name;

            if ("btnClose|btnCancel".IndexOf(btnId) > -1)
            {
                _lvSpinner1.Visible = true;
                _dvSpinner1.Visible = !_lvSpinner1.Visible;
            }
            else if (btnId == "btnSave")
            {
                //Todo: Refresh list view
                MessageBox.Show("Todo: Save and reload data from db");
            }
        }

    }
}
