﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class timkiem : Form
    {
        public timkiem()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void timkiem_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text + ":";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView1, "select*from tblSach where " + comboBox1.Text + " like N'%" + textBox1.Text + "%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView2, "select*from tblSach where MASACH like'%" + textBox2.Text + "%'or TENSACH like'%" + textBox3.Text + "%'or MATG like'%" + textBox4.Text + "%'or MANXB like'%" + textBox5.Text + "%'or MaLV like'%" + textBox7.Text + "%'or NAMXB='" + textBox6.Text + "'or SOLUONG='" + textBox8.Text + "'or NGAYNHAP='" + maskedTextBox1.Text + "'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
