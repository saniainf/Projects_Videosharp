using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretPicture
{
    public partial class FormSecretPicture : Form
    {
        public FormSecretPicture()
        {
            InitializeComponent();
        }

        private void buttonShow1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._1_janapanfilova;
        }
    }
}
