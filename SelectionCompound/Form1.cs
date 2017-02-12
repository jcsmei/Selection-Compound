using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SelectionCompound
{
    public partial class frmSelectionConjunction : Form
    {
        public frmSelectionConjunction()
        {
            InitializeComponent();
        }

        private void btnConjunction_Click(object sender, EventArgs e)
        {
            string strIncomeCOndition = Interaction.InputBox("Do you meet the income condition? Type Y for Yes");
            string strResidency = Interaction.InputBox("Are you a legal resident in New York State?");
            if (strIncomeCOndition.ToUpper() == "Y" && strResidency.ToUpper() == "Y")
            {
                txtDisplay.Text = "You are eligible for the state aid package. Please full out this form.";
            }
            else
            {
                txtDisplay.Text = "Sorry, you are not eligible for the state aid package.";
            }
        }

        private void btnDisjunction_Click(object sender, EventArgs e)
        {
            string strCoupon = Interaction.InputBox("Do you have a coupon? Tye Y for Yes");
            string strMembershipCard = Interaction.InputBox("Do you have a membership card?");
            if (strCoupon.ToUpper() == "Y" && strMembershipCard.ToUpper() == "Y")
            {
                txtDisplay.Text = "You get a 10% disocunt. 18 dollars";
            }
            else
            {
                txtDisplay.Text = "20 dollar please.";
            }
        }

        private void btnNegation_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox("Is that recyclable? Y for Yes and other letters for No.");
            if (!(strUser.ToUpper() == "Y"))
            {
                txtDisplay.Text = "Throw it in the garbage can.";
            }
            else
            {
                txtDisplay.Text = "Put in the recycle bin.";
            }
        }

        private void btnExclusiveDisjunction_Click(object sender, EventArgs e)
        {
            string strEreader = Interaction.InputBox("Do you want a eReader? Y for Yes");
            string strCellphone = Interaction.InputBox("Do you want a cellphone? Y for Yes");
            if (strEreader.ToUpper() == "Y" ^ strCellphone.ToUpper() == "Y")
            {
                txtDisplay.Text = "You get what you want!";
            }
            else
            {
                txtDisplay.Text = "You get nothing!";
            }
        }
    }
}
