namespace A1UserLogin
{
    public class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Login()
        {
            if (string.IsNullOrWhiteSpace(UserName) && string.IsNullOrWhiteSpace(Password))
            {
                return "Provide Username and Password";
            }
            
            else if (UserName == "Jhon" && Password == "Jhon123")
            {
                return "Login Successful";
            }
            else
            {
                return "Login Failed";
            }
        }
    }
}