using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            double englishAve = Convert.ToDouble(textBox2.Text);
            double mathAve = Convert.ToDouble(textBox3.Text);
            double scienceAve = Convert.ToDouble(textBox4.Text);
            double filipinoiAve = Convert.ToDouble(textBox5.Text);
            double historyAve = Convert.ToDouble(textBox6.Text);
            double totalGrade = englishAve + mathAve + scienceAve + filipinoiAve + historyAve; 

            double average = totalGrade / 5;

            label8.Text = average >= 75 ? "The student passed." + "The general average of " + textBox1.Text + " is " + average : "The student failed.";
                
        }
    }
}
