using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glasanje {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private static int For1 = 0;
        private static int Against1 = 0;
        private static int Abstained1 = 0;

        private void Form1_Load(object sender, EventArgs e) {
            GlasanjeComboBox.Items.Add("FOR");
            GlasanjeComboBox.Items.Add("AGAINST");
            GlasanjeComboBox.Items.Add("ABSTAINED");
        }

        private void VoteBtn_Click(object sender, EventArgs e) {
            if (OIBTextBox.Text == "") {
                MessageBox.Show("OIB nije unesen!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else { 
                if (GlasanjeComboBox.SelectedIndex == 0) {
                    For1++;
                    ForLabel.Text=For1.ToString();
                } else if(GlasanjeComboBox.SelectedIndex == 1) {
                    Against1++;
                    AgainstLabel.Text= Against1.ToString();
                } else if(GlasanjeComboBox.SelectedIndex == 2) {
                    Abstained1++;
                    AbstainedLabel.Text= Abstained1.ToString();
                }
            }
        }
    }
}
