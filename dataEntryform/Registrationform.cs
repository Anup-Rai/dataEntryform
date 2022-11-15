using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataEntryform
{
    public partial class Registrationform : Form
    {
        public Registrationform()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {   //exception handling
            try
            {   //creating variables for textboxes
                var fullName = tb_fullname.Text;
                var address = tb_address.Text;
                var email = tb_email.Text;
                var mobileno = tb_mobileno.Text;

                //creating validation condition
                if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(address)
                    || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(mobileno)
                    )
                {
                    // isValid = false;
                    MessageBox.Show("Please fill up the missing information.");
                }

                else if (emailValid_test(email) == false)
                {
                    MessageBox.Show("Please enter email correctly.");
                }
                else
                {   //creating object of entity container
                    registerInfoEntities registerInfoEntities = new registerInfoEntities();

                    //creating object of table
                    var registerIntotable = new infoTable();

                    //Getting textbox values for table 
                    registerIntotable.full_name = fullName;
                    registerIntotable.address = address;
                    registerIntotable.email = email;
                    registerIntotable.mobile_no = Convert.ToDecimal(mobileno);

                    //Adding textbox values into table
                    registerInfoEntities.infoTables.Add(registerIntotable);
                    registerInfoEntities.SaveChanges();
                    MessageBox.Show("Entered sucessfully!");
                }
               
            }
            catch (Exception ex)
            {   //Display error message
                MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.InnerException.Message);
                //throw;
            }
        }

        //email validation
        private bool emailValid_test(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

        //menustrip option
        private void tsm_manageData_Click(object sender, EventArgs e)
        {
            var manage_data = new ManageData();
            manage_data.ShowDialog();
        }

    }
}
