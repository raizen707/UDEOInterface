using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDEOInterface.Class;

namespace UDEOInterface
{
    public partial class Form1 : Form
    {
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private EmployeeListSource employeeListSource1;

        public Form1()
        {
            InitializeComponent();
        }


    }
}
