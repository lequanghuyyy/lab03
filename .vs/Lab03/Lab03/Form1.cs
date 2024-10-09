using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }
        Provider provider = new Provider();
        public List<String> GetlistComboxBo()
        {
            string query = "exec GetThongTinSinhVien";
            DataTable data = provider.ExcureQuery(query);
            List<String> list = new List<String>();
            foreach (DataRow item in data.Rows)
            {
             
                list.Add(item["Quequan"].ToString());
               
            }
            return list;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string text = comboBoxQueQuan.SelectedItem.ToString();
        
            DataTable data = provider.ExcureQueryHavePara(text);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxQueQuan.DataSource = GetlistComboxBo();
           
        }

        private void comboBoxQueQuan_SelectedValueChanged(object sender, EventArgs e)
        {
            string text = comboBoxQueQuan.SelectedItem.ToString();
            dataGridView1.DataSource = text;
            DataTable data = provider.ExcureQueryHavePara(text);
            dataGridView1.DataSource = data;
        }

        private void buttonTatca_Click(object sender, EventArgs e)
        {
            string query = "exec GetThongTinSinhVien";
            DataTable data = provider.ExcureQuery(query);
            dataGridView1.DataSource= data;
        }
    }
}
