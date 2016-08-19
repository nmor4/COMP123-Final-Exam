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
            fname value

            List<string> FirstNames = new List<string>();
            List<string> LastNames = new List<string>();

            foreach (string fname in FirstNameListBox.Items)
            {
                FirstNames.Add(fname);
            }

            FirstNameTextbox.Text = this._random.Next(FirstNames.)


        }
        


        //Event Handlers--------------------------------------
        private void GenerateButton_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
