using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator
{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void LeftBtn_Click(object sender, EventArgs e){
            if (LeftBtn.Tag == "English") {
                LeftBtn.Tag = "Latin";
                LeftBtn.Text = "Sinister";
            }
            else if (LeftBtn.Tag == "Latin")
            {
                LeftBtn.Tag = "English";
                LeftBtn.Text = "Left";
            }
        }

        private void CenterBtn_Click(object sender, EventArgs e){
            if (CenterBtn.Tag == "English"){
                CenterBtn.Tag = "Latin";
                CenterBtn.Text = "Medium";
            }
            else if (CenterBtn.Tag == "Latin")
            {
                CenterBtn.Tag = "English";
                CenterBtn.Text = "Center";
            }
        }

        private void RightBtn_Click(object sender, EventArgs e){
            if (RightBtn.Tag == "English"){
                RightBtn.Tag = "Latin";
                RightBtn.Text = "Dexter";
            }
            else if (RightBtn.Tag == "Latin")
            {
                RightBtn.Tag = "English";
                RightBtn.Text = "Right";
            }

        }

        private void Language_Click(object sender, EventArgs e)
        {
            if (Language.Tag == "English")
            {
                RightBtn.Tag = "Latin";
                RightBtn.Text = "Dexter";
                CenterBtn.Tag = "Latin";
                CenterBtn.Text = "Medium";
                LeftBtn.Tag = "Latin";
                LeftBtn.Text = "Sinister";
                Language.Tag = "Latin";
            }
            else if (Language.Tag == "Latin")
            {
                RightBtn.Tag = "English";
                RightBtn.Text = "Right";
                CenterBtn.Tag = "English";
                CenterBtn.Text = "Center";
                LeftBtn.Tag = "English";
                LeftBtn.Text = "Left";
                Language.Tag = "English";
            }
        }
    }
}
