using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopUi
{
    public partial class ResultUi : Form
    {
        Result aResult=new Result();
        public ResultUi()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            aResult.Physics = Convert.ToDouble (physicsTextBox.Text);
            aResult.Chemistry = Convert.ToDouble (chemistryTextBox.Text);
            aResult.Math = Convert.ToDouble (mathTextBox.Text);

            physicsTextBox.Clear();
            chemistryTextBox.Clear();
            mathTextBox.Clear();

            averageTextBox.Text = aResult. GetAvarage().ToString();
            gradeTextBox.Text = aResult.GetGradePoint();

        }
    }
}
