using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamrin4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string brand = textBox1.Text;
            int speed = Convert.ToInt32(textBox2.Text);
            car car = new car(brand, speed);
            label3.Text = car.Getcarinfo();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
public class car
{
    private string brand;
    private int speed;
    public car (string brandname, int speedvalue)
    {
        brand = brandname;
        speed = speedvalue;
    }
    ~car()
    {
        MessageBox.Show("مشخصات خودرو:\n " + "برند:" + brand + "\n" + speed + "کیلومتر بر ساعت ");
    }
    public string Getcarinfo()
    {
        return "برند:\n" + brand + "\n" + "سرعت:\n" + speed + "کیلومتر بر ساعت ";
    }
}
