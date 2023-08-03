using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sozler
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var notes = DataStore.Notes;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text)&&!string.IsNullOrEmpty(txtUsername.Text))
            {
                if(DataStore.AppUser.Username == txtUsername.Text&& DataStore.AppUser.Password==txtPassword.Text)
                {
                    Form1 form1=new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
            }
            else
            {
                MessageBox.Show("alanları boş bırakmayınız");
            }
        }
    }
}
