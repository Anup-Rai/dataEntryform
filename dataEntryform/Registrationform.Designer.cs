namespace dataEntryform
{
    partial class Registrationform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_registration = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_mobileno = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_mobileno = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_manageData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_registration
            // 
            this.lb_registration.AutoSize = true;
            this.lb_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_registration.Location = new System.Drawing.Point(330, 37);
            this.lb_registration.Name = "lb_registration";
            this.lb_registration.Size = new System.Drawing.Size(128, 26);
            this.lb_registration.TabIndex = 0;
            this.lb_registration.Text = "Registration";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(221, 85);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(97, 24);
            this.lb_fullname.TabIndex = 0;
            this.lb_fullname.Text = "Full Name";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(221, 125);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(80, 24);
            this.lb_address.TabIndex = 0;
            this.lb_address.Text = "Address";
            // 
            // lb_mobileno
            // 
            this.lb_mobileno.AutoSize = true;
            this.lb_mobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mobileno.Location = new System.Drawing.Point(221, 165);
            this.lb_mobileno.Name = "lb_mobileno";
            this.lb_mobileno.Size = new System.Drawing.Size(99, 24);
            this.lb_mobileno.TabIndex = 0;
            this.lb_mobileno.Text = "Mobile no.";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(221, 204);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(57, 24);
            this.lb_email.TabIndex = 0;
            this.lb_email.Text = "Email";
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(367, 85);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(200, 20);
            this.tb_fullname.TabIndex = 1;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(367, 125);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(200, 20);
            this.tb_address.TabIndex = 1;
            // 
            // tb_mobileno
            // 
            this.tb_mobileno.Location = new System.Drawing.Point(367, 165);
            this.tb_mobileno.Name = "tb_mobileno";
            this.tb_mobileno.Size = new System.Drawing.Size(200, 20);
            this.tb_mobileno.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(367, 204);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(200, 20);
            this.tb_email.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(223, 267);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(95, 30);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_manageData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_manageData
            // 
            this.tsm_manageData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsm_manageData.Name = "tsm_manageData";
            this.tsm_manageData.Size = new System.Drawing.Size(89, 20);
            this.tsm_manageData.Text = "Manage Data";
            this.tsm_manageData.Click += new System.EventHandler(this.tsm_manageData_Click);
            // 
            // Registrationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_mobileno);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_fullname);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_mobileno);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.lb_registration);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Registrationform";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_registration;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_mobileno;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_mobileno;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_manageData;
    }
}

