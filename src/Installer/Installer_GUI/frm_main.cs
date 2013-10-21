using System;
using System.Windows.Forms;

namespace Installer_GUI {
    public partial class frm_main : Form {
        public frm_main() {
            InitializeComponent();
        }


        private void frm_main_Load(object sender, EventArgs e) {

        }

        private void btn_step1_next_Click(object sender, EventArgs e) {
            tabs_main.SelectTab(1);
        }

        private void btn_step1_back_Click(object sender, EventArgs e) {
            tabs_main.SelectTab(0);
        }

        private void btn_step2_next_Click(object sender, EventArgs e) {
            tabs_main.SelectTab(2);
        }
 


    }
}
