namespace Final_Project
{
    public partial class Form1 : Form
    {
        AppInformation userDb;
        List<Login> userList;
        public Form1()
        {
            userDb = new AppInformation();
            InitializeComponent();

            //userList = new List<Login>();
            userList = userDb.myUser.Select(u => u).ToList();

            foreach (Login user in userList)
            {
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Login addUser = new Login { Email = txtEmail.Text, Password = txtPassword1.Text, ConfirmPassword = false, FirstName = txtFirst.Text, LastName = txtLast.Text};

            string password1 = txtPassword1.Text;
            string password2 = txtPassword2.Text;

            try
            {
                if (password1 == password2)
                {
                    userDb.myUser.Add(addUser);
                    userDb.SaveChanges();
                    lblError.Text = "You have been Added";
                    lblError.ForeColor = Color.Black;
                }
                else
                {
                    lblError.Text = "Password dose not match";
                }
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}

// https://www.dotnetstuffs.com/how-to-close-form1-and-open-form2-c-sharp/