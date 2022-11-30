namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username= txtUsername.Text;
            password= txtPassword.Text;

            MenuForm mf = new MenuForm(username,password);

            if (username == "Sintia" & password == "1234")
            {
                mf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }
        }
    }
}