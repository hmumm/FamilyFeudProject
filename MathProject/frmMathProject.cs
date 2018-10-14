using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProject
{
    public partial class frmMathProject : Form
    {
        public frmMathProject()
        {
            InitializeComponent();
        }

        private void btnAlgorithm1_Click(object sender, EventArgs e)
        {
            try
            {
                int response;
                response = int.Parse(txtResponse1.Text);

                //if the response is greater than 50 it has to be the most popular 
                //because the next highest could be 49 which would be less
                if(response > 50)
                {
                    lblAlgorithm1Result.Text = "This is the most popular result";
                } else
                {
                    lblAlgorithm1Result.Text = "This is not necessarily the most popular result";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlgorithm2_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber;
                int secondNumber;

                firstNumber = int.Parse(txtA2Response1.Text);
                secondNumber = int.Parse(txtA2Response2.Text);

                //check if one number automatically is the most popular without the other
                if(firstNumber > 50)
                {
                    lblAlgorithm2Result.Text = "The first number must be the most popular response";
                }
                else if(secondNumber > 50)
                {
                    lblAlgorithm2Result.Text = "The second number must be the most popular response";
                }
                //if their sum is greater then 66 they have to be the most popular response
                else if((firstNumber + secondNumber) > 66)
                {
                    //if they are the same they both are
                    if(firstNumber == secondNumber)
                    {
                        lblAlgorithm2Result.Text = "Both are the most popular response";
                    }
                    //else whichever is greater is the most popular
                    else if(firstNumber > secondNumber)
                    {
                        lblAlgorithm2Result.Text = "The first number must be the most popular response";
                    }
                    else
                    {
                        lblAlgorithm2Result.Text = "The second number must be the most popular response";
                    }
                //if it makes it through the rest then it is not the most popular response
                } else
                {
                    lblAlgorithm2Result.Text = "Neither is the most popular response";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
