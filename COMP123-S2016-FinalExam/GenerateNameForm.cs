using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        

        Random _random = new Random();

        public GenerateNameForm()
        {
            InitializeComponent();
        }

        //Private methods----------------------------------------
        private void GenerateNames()
        {
            int fnamevalue;
            int lnamevalue;

            List<string> FirstNames = new List<string>();
            List<string> LastNames = new List<string>();

            foreach (string fname in FirstNameListBox.Items)
            {
                FirstNames.Add(fname);
            }
            foreach (string lname in LastNameListbox.Items)
            {
                LastNames.Add(lname);
            }


            fnamevalue = _random.Next(0, 14);
            FirstNameTextbox.Text = FirstNames[fnamevalue];

            lnamevalue = _random.Next(0,14);
            LastNameTextBox.Text = LastNames[lnamevalue];
        }



        //Event Handlers--------------------------------------
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.character.FirstName = FirstNameTextbox.Text;
            Program.character.LastName = LastNameTextBox.Text;
            this.Hide();
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            this.GenerateNames();
        }
    }
}
