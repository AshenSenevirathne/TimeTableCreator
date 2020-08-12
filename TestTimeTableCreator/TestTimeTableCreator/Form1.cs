using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTimeTableCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            lct1.BringToFront();
        }

        private void lec_Click(object sender, EventArgs e)
        {
            panel4.Location = lec.Location;
            lct1.BringToFront();
            
        }


        private void stu_Click(object sender, EventArgs e)
        {
            panel4.Location = stu.Location;
            std1.BringToFront();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
