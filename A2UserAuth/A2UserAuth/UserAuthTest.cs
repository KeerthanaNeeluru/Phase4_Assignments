using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2UserAuth
{
    [TestFixture]
    internal class UserAuthTest
    {
        public UserAuthenticator auth;
        [SetUp]
        public void Setup()
        {
            auth=new UserAuthenticator();
        }
        [Test]
        public void TestUserReg()
        {
            Assert.IsTrue(auth.RegUser("user1", "pwd1"));
            Assert.IsFalse(auth.RegUser("user1", "pwd2"));
        }
        [Test]
        public void TestUserLog()
        {
            auth.RegUser("user3", "pwd3");
            Assert.IsTrue(auth.logUser("user3", "pwd3"));
          
            Assert.IsFalse(auth.logUser("nonexistentuser", "password"));
        }
        [Test]
        public void TestPwdReset()
        {
            auth.RegUser("user4", "pwd4");
            Assert.IsTrue(auth.ResetPwd("user4", "newpwd4"));
            Assert.IsFalse(auth.ResetPwd("userNotExist", "newpwd"));
        }
    }
}
