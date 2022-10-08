using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassDeveloper;

namespace Assignment_7_1
{
    public partial class Form1 : Form
    {
        List<DeveloperAttribute> devop;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            devop = new List<DeveloperAttribute>();
            devop.Add(new DeveloperAttribute() { Name = "Jason", DeveloperGrade = "B", Review = false});
            devop.Add(new DeveloperAttribute() { Name = "Smith", DeveloperGrade = "A", Review = true });
            dataGridView1.DataSource = devop;
            dataGridView1.Columns[3].Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
