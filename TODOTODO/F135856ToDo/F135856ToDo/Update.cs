using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F135856ToDo
{
    public partial class Update : Form
    {
        public Update(DateTime id)
        {
            InitializeComponent();
            this.Load += new EventHandler(frmEdit_Load);
            this.SaveButtonClick.Click += new EventHandler(btnSave_Click);
            db = new DBAccess(); // create connection to database
            student = db.TODOes.Single(st => st.id ==id); // load student object that matches the id
        }
        DBAccess db;
        private TODO student;
        void frmEdit_Load(object sender, EventArgs e)
        {
            
        }
        void btnSave_Click(object sender, EventArgs e)
        {
            student.finished = Convert.ToBoolean(txtFinished);
            db.SaveChanges(); // commit the command
            this.Close(); // close the window and show message
            MessageBox.Show("Edit student successfully!");
        }

    }
}
