using SQLite;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace WindowsFormsApp42
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        object add()
        {
            var add = new Note()
            {
                Title = txtTitle.Text,
                Text = txtText.Text,
                Date = DateTime.Now,

            };
            return add;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refershGridSqlite();
            refreshGridLitedb();
        }
       
        

        void refreshGridLitedb()
        {
            using (var db = new SQLiteConnection(Note.pathLitedb()))
            {

                try
                {
                    dgvShowNotes.DataSource = db.Table<Note>().ToList();
                }
                catch
                {

                }
            }
        }
        void refershGridSqlite()
        {
            using (var db = new SQLiteConnection(Note.pathSqlite()))
            {
                
                try
                {
                    dgvShowNotes.DataSource = db.Table<Note>().ToList();
                }
                catch
                {

                }
            }
        }

        void cleanTextBox()
        {
            txtTitle.Text = "";
            txtText.Text = "";

        }

        bool checkValue()
        {
            if (txtTitle.Text == "")
            {

                MessageBox.Show("ابتدا متن یا عنوان را وارد نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtText.Text == "")
            {
                MessageBox.Show("ابتدا متن یا عنوان را وارد نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        
       
        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            
            if (checkValue())
            {
               


                if (rbSqliteDb.Checked == true)
                {
                    var db = new SQLiteConnection(Note.pathSqlite());
                    db.CreateTable<Note>();
                    db.Insert(add());
                    db.Close();
                    cleanTextBox();
                    refershGridSqlite();
                    refreshGridLitedb();
                    File.Delete(Note.pathLitedb());
                }
                if (rbLiteDb.Checked == true)
                {
                    var db = new SQLiteConnection(Note.pathLitedb());
                    db.CreateTable<Note>();
                    db.Insert(add());
                    db.Close();
                    cleanTextBox();
                    refershGridSqlite();
                    refreshGridLitedb();
                    File.Delete(Note.pathSqlite());

                }
            }
        }


        private void BtnDeleteNote_Click(object sender, EventArgs e)
        {
        }
    }
}
