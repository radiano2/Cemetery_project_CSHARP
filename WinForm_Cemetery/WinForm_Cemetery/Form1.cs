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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.testDataSet.positions);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            positionsTableAdapter.Update(testDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this position", "Deleting", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        

        

        private void button3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                positionsTableAdapter.Update(testDataSet);
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            positionsTableAdapter.Update(testDataSet);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            positionsTableAdapter.Update(testDataSet);
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            Form3 searchform = new Form3();
            searchform.Owner = this;
            searchform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            positionsTableAdapter.Update(testDataSet);
            
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("my name is Van, I'm 30 years old and I'm from Japan. I'm an artist, I'm a performance artist. I'm hired for people to fulfill their fantasies, their deep, dark fantasies. I was gonna be a movie star, you know with modeling and uh acting. After 102 auditions and small parts, you know I decided that I had enough. Then I get into escort work. The clientele requested a lot of um fetishes. So I just decided to go you know full master and change my whole entire house into a dungeon. Um dungeon master, you know with a full dungeon in my house. And uh yep, It's going really well. Fisting is 300 bucks, and uh usually the guy is pretty much high on a popper to get to really get relaxed, you know and I have this long latex glove that goes all the way up to my armpit, and uh then I put on a surgical latex glove just up to my hand. Then just lube it up, and uh it's a long process you know to get your whole get your whole arm up there. But uh, It's an intense feeling for the other person, I think for myself too it's uh, you're going places that um even though its physical with your hand for but, some reason it's also emotional, it's more psychological too. And you know we both reach the same place too it's really strange at the same time. And after a session like that, I get really exhausted from it at the end.﻿");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}
