using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter5
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox2.Checked, checkBox1.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int) numericUpDown2.Value, checkBox3.Checked, textBox1.Text);
            DisplayBirthdayPartyCost()
        }

        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int) numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = (checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = (checkBox2.Checked);
            DisplayDinnerPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int) numericUpDown2.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = checkBox3.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBox1.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            label5.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            label7.Text = cost.ToString("c");
        }
    }

}
