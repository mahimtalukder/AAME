﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Developer_page4 : Form
    {
        string id;
        public Developer_page4(string ID)
        {
            InitializeComponent();
            id = ID;
            Developer dv = new Developer();
            label1.Text = dv.get_info(id).NAME;
            pictureBox3.Image = dv.get_info(id).PICTURE;
            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.MediumPurple;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            dataGridView1.DataSource = dv.bind_lactureDataGrid(id);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard da = new Dashboard();
            da.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Developer_Dashboard dvd = new Developer_Dashboard(id);
            dvd.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_page log = new Login_page();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Developer_page1 db = new Developer_page1(id);
            db.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Developer_page2 db = new Developer_page2(id);
            db.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Developer_page3 db = new Developer_page3(id);
            db.Show();
        }
        byte[] barFile = null;
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "(Lacture note name)")
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Title = "Choce file";
                openFileDialog1.Filter = "PDF File(*.pdf) |*.pdf";
                openFileDialog1.Filter = "PDF File(*.pdf) |*.pdf";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string sFileName = "";
                    long nLength = 0;

                    if (openFileDialog1.FileName != "")
                    {
                        FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                        FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                        sFileName = fileInfo.Name;
                        nLength = fs.Length;
                        barFile = new byte[fs.Length];
                        fs.Read(barFile, 0, Convert.ToInt32(fs.Length));
                        fs.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter lacture note name fast", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text== "(Lacture note name)")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "(Lacture note name)";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (barFile != null)
            {
                Developer dv = new Developer();
                dv.insert_Lacture(id, textBox1.Text, barFile);
                dataGridView1.DataSource = dv.bind_lactureDataGrid(id);
                textBox1.Text = "(Lacture note name)";
                textBox1.ForeColor = Color.LightGray;
            }
            else
            {
                MessageBox.Show("Plase Select file", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                Edit_Lacture_Note edit = new Edit_Lacture_Note(id,Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
                edit.Show();
                this.Close();
                
                
            }
            
            else if(dataGridView1.Columns[e.ColumnIndex].Name == "Column2")
            {
                Developer dv = new Developer();
                dv.download_lactureNote(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value), id);
                MessageBox.Show("Shaved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Developer_page5 dv = new Developer_page5(id);
            dv.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Developer_page6 developer = new Developer_page6(id);
            developer.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Developer_page7 mamber = new Developer_page7(id);
            mamber.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Developer_page8 db = new Developer_page8(id);
            db.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Developer_page9 dv = new Developer_page9(id);
            dv.Show();
        }
    }
}
