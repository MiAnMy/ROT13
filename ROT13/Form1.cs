using System;
using System.Windows.Forms;

namespace ROT13
{
    public partial class ROT13 : Form
    {
        public ROT13()
        {
            InitializeComponent();
        }
        private void To_ROT13_Click(object sender, EventArgs e)
        {
            Result.Text=ROT13Class.Rot13(Value.Text);
        }
    }
}
