using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProverkaPlat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //проверяем что все чекбоксы проставлены

            bool allChecked = tabControl1.TabPages[0].Controls.OfType<CheckBox>().All(c => c.Checked);
            if (/*checkBox1.Checked == true &&
                checkBox2.Checked == true &&
                checkBox3.Checked == true &&
                checkBox4.Checked == true &&
                checkBox5.Checked == true &&
                checkBox6.Checked == true &&
                checkBox7.Checked == true &&
                checkBox8.Checked == true &&
                checkBox9.Checked == true &&
                checkBox10.Checked == true &&
                checkBox11.Checked == true &&
                checkBox12.Checked == true &&
                checkBox13.Checked == true &&
                checkBox14.Checked == true &&
                checkBox15.Checked == true &&
                checkBox16.Checked == true &&
                checkBox17.Checked == true &&
                checkBox18.Checked == true &&
                checkBox19.Checked == true*/
                allChecked)
            {
                textBox1.BackColor = Color.Chartreuse;
                return;
            }
            textBox1.BackColor = Color.OrangeRed;
        }


        //Для вкладки дни
        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            //снимаем галки со всех чек боксов
            foreach (Control cBox in tabControl1.TabPages[0].Controls)
            {
                if (cBox is CheckBox)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }
        }

        //Для вкладки неделя
        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            //снимаем галки со всех чек боксов
            foreach (Control cBox in tabControl1.TabPages[1].Controls)
            {
                if (cBox is CheckBox)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }
        }


        //чекбоксы на вкадки неделя
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            bool allChecked = tabControl1.TabPages[1].Controls.OfType<CheckBox>().All(c => c.Checked);
            if (allChecked)
            {
                textBox2.BackColor = Color.Chartreuse;
                return;
            }
            textBox2.BackColor = Color.OrangeRed;
        }


        
        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //снимаем галки со всех чек боксов
            foreach (Control cBox in tabControl1.TabPages[2].Controls)
            {
                if (cBox is CheckBox)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }

        }


        //Для месяца
        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            bool allChecked = tabControl1.TabPages[2].Controls.OfType<CheckBox>().All(c => c.Checked);
            if (allChecked)
            {
                textBox3.BackColor = Color.Chartreuse;
                return;
            }
            textBox3.BackColor = Color.OrangeRed;
        }
    }
   }

