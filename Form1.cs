using System.Text.RegularExpressions;

namespace _17thang10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateEmail(string email)
        {
            string emailRegex = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$";
            return Regex.IsMatch(email, emailRegex);
        }

        private bool ValidatePassword(string password)
        {
            string passwordRegex = @"^(?=.*[!@#$%^&*()_+{}:;'?/>.<,])[A-Za-z\d!@#$%^&*()_+{}:;'?/>.<,]{8,}$";
            return Regex.IsMatch(password, passwordRegex);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;
            if (!ValidateEmail(email))
            {
                lblMessage.Text = "Email không hợp lệ!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else if (!ValidatePassword(password))
            {
                lblMessage.Text = "Mật khẩu phải có ít nhất 8 ký tự và bao gồm ít nhất 1 ký tự đặc biệt!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblMessage.Text = "Đăng ký thành công!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}