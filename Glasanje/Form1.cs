using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                MessageBox.Show("OIB ne smije biti prazan!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(System.Text.RegularExpressions.Regex.IsMatch(OIBTextBox.Text, "[^0-9]")) { 
                MessageBox.Show("OIB mora biti broj!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (OIBTextBox.Text.Length < 11 || OIBTextBox.Text.Length > 11) {
                MessageBox.Show("OIB mora imati 11 znamenki!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                if (GlasanjeComboBox.SelectedIndex == 0) {
                    For1++;
                    ForLabel.Text = For1.ToString();
                } else if (GlasanjeComboBox.SelectedIndex == 1) {
                    Against1++;
                    AgainstLabel.Text = Against1.ToString();
                } else if (GlasanjeComboBox.SelectedIndex == 2) {
                    Abstained1++;
                    AbstainedLabel.Text = Abstained1.ToString();
                }
            }
        }
    }
}
