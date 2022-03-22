using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT4
{
    public partial class Form2 : Form
    {
        public delegate void Mydel(string _mssv, string _name, bool gender, string _lopHp);
        public Form2()
        {
            InitializeComponent();
        }
        public Mydel d;
        SV sv= new SV();
        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            sv.MSSV = txtMSSV.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            sv.Name = txtName.Text;
        }

        private void cBAddLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            sv.LopHP = cBAddLop.SelectedItem.ToString();
        }

        private void rdFe_CheckedChanged(object sender, EventArgs e)
        {
            sv.Gender = rdFe.Checked;
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            sv.Gender = rdMa.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d(sv.MSSV, sv.Name, sv.Gender, sv.LopHP);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
