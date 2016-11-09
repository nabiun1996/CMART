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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
            
            this.btnSave.Click += new EventHandler(SaveButtonClick);
        }
        
        void SaveButtonClick(object sender, EventArgs e)
        {
            //DateTime class_id = (DateTime)this.cboClass.SelectedValue; // get selected id value from combobox
            string id; // get inputted value from textbox
            string title = this.txtTitle.Text;
            string content = this.txtContent.Text;
            string deadline = this.txtDeadline.Text;
            string finished = this.txtFinished.Text;

            DBAccess db = new DBAccess(); // open connection to database
            TODO student = new TODO(); // create a new student object
            student.id = DateTime.Now; // set all data for student object
            //student.id = id;
            student.Title = title; // then add student object to database
            student.Content = content;
            student.Deadline = Convert.ToDateTime(deadline);
            student.finished = Convert.ToBoolean(finished);
            db.TODOes.AddObject(student);
            db.SaveChanges(); // commit the command
            this.Close(); // close the window and show message
            MessageBox.Show("Add Task successfully!");
        }

    }
}
