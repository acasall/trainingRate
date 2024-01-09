using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trainingRate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UserInput(ref int age, ref int restingRate)// 1
        {
            int.TryParse(txtAge.Text, out age);
            int.TryParse(txtRestingRate.Text, out restingRate);
        }
        private int CalculateRate(int age, int restingRate)// 2
        {
            double trainingRate;

            trainingRate = 0.6 * (220 - age - restingRate) + restingRate;

            return (int)trainingRate;
        }

        private void DisplayRate(int trainingRate)
        {
            txtTrainingRate.Text = trainingRate.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1) Method to accept user input 
            // 2) Method to calculate training heart rate
            // 3) Method to display the training rate
        
            int age =0, restingRate =0;
            int trainingRate;

            UserInput(ref age, ref restingRate);

            trainingRate= CalculateRate(age, restingRate); //passes the parameters by value which is why we dont use the int

            DisplayRate(trainingRate);
        }

    }
}
