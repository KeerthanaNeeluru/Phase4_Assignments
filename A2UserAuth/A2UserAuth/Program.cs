
namespace A2UserAuth
{
    internal class UserAuthenticator
    {

        public string Uname { get; set; }
        public string Upwd { get; set; }

        public UserAuthenticator()
        {
            Uname = null;
            Upwd = null;
        }
        public bool RegUser(string uname, string pwd)
        {
            if (Uname == null)
            {
                Uname = uname;
                Upwd = pwd;
                return true;
            }
            return false;
        }
        public bool logUser(string uname, string pwd)
        {
            if (Uname == uname || Upwd == pwd)
            {
                return true;
            }
            return false;
        }
        public bool ResetPwd(string uname, string pwd)
        {
            if (Uname == uname)
            {
                Upwd = pwd;
                return true;
            }
            return false;
        }
    }
    internal class program 
    {
        
    
    static void Main(string[] args)
        {

        }
    }
}
