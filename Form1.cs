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
    public partial class Form1 : Form
    {
        List<SV> l = new List<SV>();
        List<SV> l1 = new List<SV>();
        List<SV> l2 = new List<SV>();
        List<SV> l3 = new List<SV>();
        List<SV> l4 = new List<SV>();
        List<SV> l5 = new List<SV>();
        public Form1()
        {
            InitializeComponent();
            CreateDB();
        }

        public DataTable DB { get; set; }

        public void CreateDB()
        {

            l.AddRange(new SV[]
            {

                new SV {MSSV = "109", Name = "NVH", Gender = true, LopHP = "20TCLC_DT3"},
                new SV {MSSV = "110", Name = "NVI", Gender = true, LopHP = "20TCLC_DT2"},
                new SV {MSSV = "111", Name = "NVJ", Gender = true, LopHP = "20TCLC_DT2"},
                new SV {MSSV = "112", Name = "NVK", Gender = false, LopHP = "20TCLC_DT2"},
                new SV {MSSV = "112", Name = "NVL", Gender = true, LopHP = "20TCLC_DT2"},
                new SV {MSSV = "102", Name = "NVA", Gender = true, LopHP = "20TCLC_DT4"},
                new SV {MSSV = "103", Name = "NVB", Gender = true, LopHP = "20TCLC_DT4"},
                new SV {MSSV = "104", Name = "NVC", Gender = false, LopHP = "20TCLC_DT4"},
                new SV {MSSV = "105", Name = "NVD", Gender = true, LopHP = "20TCLC_DT4"},
                new SV {MSSV = "106", Name = "NVE", Gender = true, LopHP = "20TCLC_DT3"},
                new SV {MSSV = "107", Name = "NVF", Gender = true, LopHP = "20TCLC_DT3"},
                new SV {MSSV = "108", Name = "NVG", Gender = false, LopHP = "20TCLC_DT3"},
            });

            l1.AddRange(new SV[]
            {

                new SV {MSSV = "104", Name = "NVC", Gender = false, LopHP = "20TCLC_DT4"},
                new SV {MSSV = "105", Name = "NVD", Gender = true, LopHP = "20TCLC_DT4"},
                new SV {MSSV = "102", Name = "NVA", Gender = true, LopHP = "20TCLC_DT4"},
                new SV {MSSV = "103", Name = "NVB", Gender = true, LopHP = "20TCLC_DT4"},
            });

            l2.AddRange(new SV[]
            {

                new SV {MSSV = "108", Name = "NVG", Gender = false, LopHP = "20TCLC_DT3"},
                new SV {MSSV = "109", Name = "NVH", Gender = true, LopHP = "20TCLC_DT3"},
                new SV {MSSV = "106", Name = "NVE", Gender = true, LopHP = "20TCLC_DT3"},
                new SV {MSSV = "107", Name = "NVF", Gender = true, LopHP = "20TCLC_DT3"}
            });

            l3.AddRange(new SV[]
            {

                new SV {MSSV = "112", Name = "NVK", Gender = false, LopHP = "20TCLC_DT2"},
                new SV {MSSV = "113", Name = "NVL", Gender = true, LopHP = "20TCLC_DT2"},
                new SV {MSSV = "110", Name = "NVI", Gender = true, LopHP = "20TCLC_DT2"},
                new SV {MSSV = "111", Name = "NVJ", Gender = true, LopHP = "20TCLC_DT2"}
            });

            DB = new DataTable();
            DB.Columns.AddRange(new DataColumn[] {
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("Họ và Tên", typeof(string)),
                new DataColumn("Giới tính", typeof(bool)),
                new DataColumn("Lớp Học Phần", typeof(string)),
            });
            //Tạo Row (tạo 3 row)

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            
                dtGv.DataSource = DB;
        }

        private void cBLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBLop.SelectedItem.ToString() == "20TCLC_DT4")
            {
                DB.Rows.Clear();
                foreach (SV i in l1)
                {
                    DB.Rows.Add(new object[] { i.MSSV, i.Name, i.Gender, i.LopHP });
                }

            }
            else if (cBLop.SelectedItem.ToString() == "20TCLC_DT3")
            {
                DB.Rows.Clear();
                foreach (SV i in l2)
                {
                    DB.Rows.Add(new object[] { i.MSSV, i.Name, i.Gender, i.LopHP });
                }
            }
            else if (cBLop.SelectedItem.ToString() == "20TCLC_DT2")
            {
                DB.Rows.Clear();
                foreach (SV i in l3)
                {
                    DB.Rows.Add(new object[] { i.MSSV, i.Name, i.Gender, i.LopHP });
                }
            }
        }

        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            foreach (SV i in l)
            {
                DB.Rows.Clear();
                if (tBSearch.Text == i.MSSV)
                {
                    l4.AddRange(new SV[]
            {
                new SV {MSSV = i.MSSV, Name = i.Name, Gender = i.Gender, LopHP = i.LopHP},
            });
                    DB.Rows.Add(new object[] { i.MSSV, i.Name, i.Gender, i.LopHP });
                }
            }
            foreach (SV i in l4)
            {
                DB.Rows.Add(new object[] { i.MSSV, i.Name, i.Gender, i.LopHP });
            }
            dtGv.DataSource = DB;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (this.dtGv.SelectedRows.Count > 0)
            {
                dtGv.Rows.RemoveAt(this.dtGv.SelectedRows[0].Index);
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            dtGv.Sort(dtGv.Columns[0], ListSortDirection.Ascending);
        }
        Form2 f = new Form2();
        private void btUpd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhap dung MSSV de Update !");
            f.Show();
            
            f.d = new Form2.Mydel(Update);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            f.Show();
            f.d = new Form2.Mydel(Add);
        }
        private void Add(string _MSSV,string _Name, bool _Gender, string _LopHP)
        {
            SV s1= new SV();
            s1.Name = _Name;
            s1.MSSV = _MSSV;
            s1.Gender = _Gender;
            s1.LopHP = _LopHP;
            if(s1.LopHP== "20TCLC_DT2")
            {
                l3.AddRange(new SV[]
            {

                new SV {MSSV = s1.MSSV, Name = s1.Name, Gender = s1.Gender, LopHP = s1.LopHP}
            });
                DB.Rows.Clear();
                foreach (SV i in l3)
                {
                    DB.Rows.Add(new object[] { i.MSSV, i.Name, i.Gender, i.LopHP });
                }
            }
            else if (s1.LopHP == "20TCLC_DT3")
            {
                l2.AddRange(new SV[]
            {

                new SV {MSSV = s1.MSSV, Name = s1.Name, Gender = s1.Gender, LopHP = s1.LopHP}
            });
                DB.Rows.Clear();
                foreach (SV i in l2)
                {
                    DB.Rows.Add(new object[] { i.MSSV, i.Name, i.Gender, i.LopHP });
                }
            }
            else if (s1.LopHP == "20TCLC_DT4")
            {
                l1.AddRange(new SV[]
            {

                new SV {MSSV = s1.MSSV, Name = s1.Name, Gender = s1.Gender, LopHP = s1.LopHP}
            });
                DB.Rows.Clear();
                foreach (SV i in l1)
                {
                    DB.Rows.Add(new object[] { i.MSSV, i.Name, i.Gender, i.LopHP });
                }
            }
        }

        private void Update(string _MSSV, string _Name, bool _Gender, string _LopHP)
        {
            int check = 0;
            foreach (SV i in l1)
            {
                if(i.MSSV == _MSSV)
                {
                    check++;
                    i.Name = _Name;
                    i.Gender = _Gender;
                    i.LopHP = _LopHP;
                }
            }
            foreach (SV i in l2)
            {
                if (i.MSSV == _MSSV)
                {
                    check++;
                    i.Name = _Name;
                    i.Gender = _Gender;
                    i.LopHP = _LopHP;
                }
            }
            foreach (SV i in l3)
            {
                if (i.MSSV == _MSSV)
                {
                    check++;
                    i.Name = _Name;
                    i.Gender = _Gender;
                    i.LopHP = _LopHP;
                }
            }
            if (check == 0)
            {
                MessageBox.Show("Khong tim thay nhan vien can Update !");
            }
            DB.Rows.Clear();
            foreach (SV i in l1)
            {
                DB.Rows.Add(new object[] { i.MSSV, i.Name, i.Gender, i.LopHP });
            }
        }

        private void dtGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
