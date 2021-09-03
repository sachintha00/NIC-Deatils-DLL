using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDgetNicDetails;

namespace NICDetails
{
    public partial class Form1 : Form
    {
        GetNicDetails nic;
        String input;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GetDetail_Click(object sender, EventArgs e)
        {
            input = txt_input.Text;
            nic = new GetNicDetails(input);

            lbl_birthyear.Text = nic.Year;
            lbl_month.Text = nic.Month;
            lbl_birthday.Text = nic.Day.ToString();
            lbl_fullbirthday.Text = nic.BirthDay;
            lbl_gender.Text = nic.Gender;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_birthyear.Text = "";
            lbl_month.Text = "";
            lbl_birthday.Text = "";
            lbl_fullbirthday.Text = "";
            lbl_gender.Text = "";
        }
    }
}
