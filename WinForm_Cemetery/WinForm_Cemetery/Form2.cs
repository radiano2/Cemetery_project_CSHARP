using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Cemetery
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();






        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AddBTN_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.testDataSet.Tables[0].NewRow();
                int ID = main.dataGridView1.RowCount + 1;
                nRow[0] = ID;
                nRow[1] = tbName.Text;
                nRow[2] = tbLastName.Text;
                nRow[3] = tbAge.Text;
                nRow[4] = tbSex.Text;
                nRow[5] = tbCauseOfDeath.Text;

                int Num;
                bool isNum = int.TryParse(tbAge.Text.ToString(), out Num); //c is your variable
                if (isNum)
                {
                    if (tbSex.Text == "male" || tbSex.Text == "female")
                    {

                        tbName.Text = "";
                        tbLastName.Text = "";
                        tbAge.Text = "";
                        tbSex.Text = "";
                        tbCauseOfDeath.Text = "";
                        main.testDataSet.Tables[0].Rows.Add(nRow);
                        main.positionsTableAdapter.Update(main.testDataSet.positions);
                        main.testDataSet.Tables[0].AcceptChanges();
                        main.dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("There are only 2 genders");
                    }


                }
                else
                {
                    MessageBox.Show("The age field must be number"); //integer
                }

                MessageBox.Show("The age field must be number"); //integer








            }
        }
        //Validation of age field
        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
