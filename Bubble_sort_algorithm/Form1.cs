using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_sort_algorithm
{
    public partial class Form1 : Form
    {
        public static string[] nums;
        
        public Form1()
        {
            InitializeComponent();
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        public static int isnotsorted(string []nums)
        {
            int answer = 0;
            for(int i=1;i<nums.Length;i++)
            {
                if(Int32.Parse(nums[i-1]) > Int32.Parse(nums[i]))
                {
                    answer = 1;
                }
            }
            return answer;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
        
        
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public static int i = 1;

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Text = "NEXT";
            Control[] textboxes = new Control[] { textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13 };
            int ii = 0;
            while (ii != nums.Length)
            {
                textboxes[ii].Visible = true;
                textboxes[ii].Text = nums[ii];
                textboxes[ii].BackColor = Color.White;
                ii++;
            }
            textboxes[i].BackColor = Color.Aqua;
            textboxes[i - 1].BackColor = Color.Aqua;
            if (Int32.Parse(nums[i - 1]) > Int32.Parse(nums[i]))
            {
                label1.Text = nums[i - 1];
                label2.Text = ">";
                label3.Text = nums[i];
                label4.Text = "swap";
            }
            else
            {
                label1.Text = nums[i - 1];
                label2.Text = "<";
                label3.Text = nums[i];
                label4.Text = "";
            }
            if (Int32.Parse(nums[i - 1]) > Int32.Parse(nums[i]))
            {
                string save = nums[i];
                nums[i] = nums[i - 1];
                nums[i - 1] = save;
                
            }
            i++;
            if(i==nums.Length)
            {

                if (isnotsorted(nums) == 0)
                {
                    textboxes[i-1].Text = nums[i-1];
                    textboxes[i - 2].Text = nums[i - 2];
                    MessageBox.Show("Array is sorted");
                    button1.Visible = true;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;
                    textBox12.Visible = false;
                    textBox13.Visible = false;
                    label1.Text = "";
                    label2.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    textBox1.Text = "";
                    i = 1;
                }
                else
                {

                    i = 1;
                }
                
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = "START";
            Control[] textboxes = new Control[] { textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13 };
            nums = textBox1.Text.Split(new Char[] { ',' });
            button1.Visible = false;
            int ii = 0;
            while (ii != nums.Length)
            {
                textboxes[ii].BackColor = Color.White;
                textboxes[ii].Visible = true;
                textboxes[ii].Text = nums[ii];
                ii++;
            }
            button2.Text = "NEXT";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
