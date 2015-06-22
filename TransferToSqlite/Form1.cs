using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferToSqlite
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        string dbfFilterString = "DBF File (*.dbf)|*.dbf";
        string sqliteFilterString = "Sqlite File|*.sqlite";
        public Form1()
        {
            InitializeComponent();
            //sqlPath.Text = 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myOpenFileDialog(dbfPath, dbfFilterString);
            
        }

        protected void myOpenFileDialog(TextBox p_textBox,string p_filter)
        {
            setOpenFileDialog(p_filter);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                p_textBox.Text = openFileDialog1.FileName;
            }
        }

        protected void setOpenFileDialog(string p_filter)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = p_filter;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myOpenFileDialog(sqlitePath, sqliteFilterString);
        }
    }
}
