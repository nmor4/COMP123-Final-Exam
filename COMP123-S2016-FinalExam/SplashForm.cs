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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        //Stops the SplashForm timer, hides the SplashForm and creates an instance of the GenerateNameForm
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Stop();
            this.Hide();
            GenerateNameForm nameGenerateForm = new GenerateNameForm();
            nameGenerateForm.Show();
        }
    }
}
