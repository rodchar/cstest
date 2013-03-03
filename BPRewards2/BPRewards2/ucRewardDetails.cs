﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPRewards2
{
    public partial class ucRewardDetails : UserControl
    {
        int _rewardId;

        public ucRewardDetails(int rewardId)
        {
            InitializeComponent();

            _rewardId = rewardId;


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
            //end todo

            ucDataGridViewHelper1.dataGridView1.DataSource = dt;
            ucDataGridViewHelper2.dataGridView1.DataSource = dt;
            ucDataGridViewHelper3.dataGridView1.DataSource = dt;
        }
    }
}