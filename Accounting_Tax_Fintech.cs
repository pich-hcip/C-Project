using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Homework
{
    public partial class Accounting_Tax_Fintech : Form
    {
        public Accounting_Tax_Fintech()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pich=new OpenFileDialog();
            if(pich.ShowDialog() == DialogResult.OK )
            {
                pictureBox2.Image=Image.FromFile(pich.FileName);
                textBoxPath.Text=pich.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int empNo = 0, age = 0;
            string name = "", title = "", dob = "",sex="";
            empNo=int.Parse(textBoxEmpNo.Text);
            age = int.Parse(textBoxAge.Text);
            name=textBoxName.Text;
            title=textBoxTitle.Text;
            DateTime timeIn ,timeOut;
            TimeSpan workHour;
            timeIn = dateTimePickerIn.Value;
            timeOut = dateTimePickerOut.Value;
            workHour=timeOut-timeIn;
            u.Text = workHour.TotalHours.ToString();
        }
    }
}
