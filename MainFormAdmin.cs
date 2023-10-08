using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOExam
{
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
            if (loginForm.userType == 2)
            {
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;   
            }
        }        

        private void MainFormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            //dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void buttonShowDB_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = examDataSet1.Items;
            sqlDataAdapter1.Fill(examDataSet1.Items);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(examDataSet1.Items);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                int id = Convert.ToInt32(selectedRow.Cells["ItemID"].Value);
                sqlConnection1.Open();
                sqlCommand1.CommandText = "DELETE FROM Items WHERE ItemID = '" + id + "'";
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                //Не работает обновление DataGridView после удаления строки
                sqlDataAdapter1.Update(examDataSet1.Items);
                dataGridView1.DataSource = examDataSet1.Items;
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
    }
}
