using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace dataEntryform
{
    public partial class edit_delete_form : Form
    {
        //creating objects
        registerInfoEntities registerInfoEntities = new registerInfoEntities();
        infoTable infoTable = new infoTable(); 

        public edit_delete_form()
        {
            InitializeComponent();
        }

        //function overloading
        public edit_delete_form(infoTable edit_form)
        {
            InitializeComponent();
            form_filled(edit_form);
        }

        //Placing values into edit delete form textboxes
        private void form_filled(infoTable edit_form)
        {
            edtb_name.Text = edit_form.full_name;
            edtb_address.Text = edit_form.address;
            edtb_mobileno.Text = Convert.ToString( edit_form.mobile_no);
            edtb_email.Text = edit_form.email;
        }

        private void edbt_save_Click(object sender, EventArgs e)
        {
            //getting values or error msg
            var new_update = registerInfoEntities.infoTables.FirstOrDefault(q=> q.full_name == edtb_name.Text);

            //placing new edited values into the table
            new_update.full_name = edtb_name.Text;
            new_update.address = edtb_address.Text;
            new_update.email = edtb_email.Text;
            new_update.mobile_no = Convert.ToDecimal(edtb_mobileno.Text);

            //saving the changes
            registerInfoEntities.SaveChanges();
            MessageBox.Show("Changed sucessfully!");
        }


        private void edbt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
