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
        List<string> FirstNames = new List<string>();
        List<string> LastNames = new List<string>();

        Random _random = new Random();

        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNames()
        {
            foreach (string fname in FirstNameListBox)
            {

            }
        }
        

        private void GenerateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
