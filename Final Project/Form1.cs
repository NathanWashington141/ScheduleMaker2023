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
            string userName = txtUsername.Text;
            string password2 = txtPassword2.Text;
           
            userList = userDb.myUser.Where(c => c.Email == userName).Where(c => c.Password == password2).ToList();
            Login? loginPassword = userDb.myUser.FirstOrDefault(email => email.Email.Equals(userName) && email.Password == password2);

            try
            {
                if (userName == "NateSoRealEmail@gmail.com" && password2 == "WhyAreYouLooking")
                {
                    Owner userLogin = new Owner();
                    userLogin.ShowDialog();

                }
                else if (loginPassword != default)
                {
                    User owner = new User();
                    owner.ShowDialog();
                }
                else
                {
                     lblError.Text = "Email or Password dose not match";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Login addUser = new()  { FirstName = txtFirst.Text, LastName = txtLast.Text, Password = txtPassword1.Text, ConfirmPassword = false, Email = txtEmail.Text, Attendees = 0, Address = "1111 Cat"};

            string password1 = txtPassword1.Text;
            string confirmPassword = txtPasswordAgain.Text;

            try
            {
                if (password1 == confirmPassword)
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
