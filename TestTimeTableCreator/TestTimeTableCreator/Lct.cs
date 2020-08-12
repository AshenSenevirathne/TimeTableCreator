using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TestTimeTableCreator
{
    public partial class Lct : UserControl
    {
        public Lct()
        {
            InitializeComponent();
            dataGridView1.DataSource = new List<Emp> { 
                new Emp{ studentID = 1, studentNAme = "Kusal"}
            };
            
        }
    }
}
