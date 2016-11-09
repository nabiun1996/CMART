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
    public partial class frmToDo : Form
    {
        public frmToDo()
        {
            InitializeComponent();
            // Register form loading event
            this.Load += new EventHandler(formLoad);
        }
        void formLoad(object sender, EventArgs e)
        {
            // When the form is loaded
            this.getListTasks(); // Load all students from database
            this.btnInsert.Click += new EventHandler(insertButtonClick);
            this.btnDelete.Click += new EventHandler(deleteButtonClick);
        }
        private void getListTasks()
        {
            DBAccess db = new DBAccess(); // create connection to your database
            this.lstToDo.DataSource = db.TODOes.ToList(); // get the list of students from database, then assign to DataSource of data grid view
            this.lstToDo.Columns["id"].Visible = true;
            this.lstToDo.Columns["Title"].Visible = true;
            this.lstToDo.Columns["Content"].Visible = true;
            this.lstToDo.Columns["Deadline"].Visible = true;
            this.lstToDo.Columns["finished"].Visible = true;
        }
        void deleteButtonClick(object sender, EventArgs e)
        {
            if (lstToDo.SelectedRows.Count == 1) // if select only one student
            {
                var row = lstToDo.SelectedRows[0]; // get the selected row
                var cell = row.Cells["id"]; // get the cell contain id information
                DateTime id = (DateTime)cell.Value; // get the id value of selected student
                DBAccess db = new DBAccess(); // connect to database
                TODO student = db.TODOes.Single(st => st.id == id); // select the student that matches the id
                db.TODOes.DeleteObject(student); // delete the selected student
                db.SaveChanges(); // commit the command
                this.getListTasks(); // refresh the students list
            }
            else
            {
                MessageBox.Show("You should select a thing!");
            }
        }
        void insertButtonClick(object sender, EventArgs e)
        {
            Insert Add = new Insert();
            Add.ShowDialog();
            this.getListTasks();
        }

        private void frmToDo_DoubleClick(object sender, EventArgs e)
        {
            if (lstToDo.SelectedRows.Count == 1) // if select only one row
            {
                var row = lstToDo.SelectedRows[0]; // get the selected row
                var cell = row.Cells["id"]; // get the id cell of the row
                DateTime id = (DateTime)cell.Value; // get the id value from the cell
                Update Edit = new Update(id); // show edit form with the selected id
                Edit.ShowDialog();
                this.getListTasks(); // refresh the list after editing
            }

        }

    }
}
