using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }
        private void Splashscreen_Load(object sender, EventArgs e)
        {
            Label1.Parent = pictureBox1;
            Label2.Parent = pictureBox1;
            Label3.Parent = pictureBox1;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Login login = new Login();
            panel2.Width += 30;
            if (panel2.Width >= 800){
                Timer1.Stop();
                login.Show();
                this.Hide();
            }
        }

    }
}
