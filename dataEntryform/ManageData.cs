﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataEntryform
{
    public partial class ManageData : Form
    {
        registerInfoEntities registerInfoEntities = new registerInfoEntities();
        infoTable InfoTable = new infoTable();

        public ManageData()
        {
            InitializeComponent();
        }

        private void ManageData_Load(object sender, EventArgs e)
        {
            var userinfo_details = registerInfoEntities.infoTables.Select
               (q => new { Id = q.id, Full_Name = q.full_name, Address = q.address, Mobile_number = q.mobile_no, Email = q.email }).
               ToList();

            dgv_userinformation_display.DataSource = userinfo_details;
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            //select a row 
            var ed_id = (int) dgv_userinformation_display.SelectedRows[0].Cells["Id"].Value;

            //quary database for record
            var ed_userinfo = registerInfoEntities.infoTables.FirstOrDefault(q => q.id == ed_id);

            //launch edit form
            var edit_form = new edit_delete_form(ed_userinfo);
            edit_form.MdiParent = this.MdiParent;
            edit_form.ShowDialog();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            var ed_id = (int)dgv_userinformation_display.SelectedRows[0].Cells["id"].Value;

            var ed_userinfo = registerInfoEntities.infoTables.FirstOrDefault(q => q.id == ed_id);

            registerInfoEntities.infoTables.Remove(ed_userinfo);
            registerInfoEntities.SaveChanges();
            MessageBox.Show("Sucessfully deleted.");

            dgv_userinformation_display.Refresh();

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
