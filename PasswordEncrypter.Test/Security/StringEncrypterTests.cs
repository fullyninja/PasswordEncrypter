using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordEncrypter.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PasswordEncrypter.Security.Tests
{
    [TestClass()]
    public class StringEncrypterTests
    {
        [TestMethod()]
        public void ToSecureStringTest()
        {
            // Not really a proper test but can't do much else apart from recreate the actual function.
            // Have to test conversion to and from a secure string in the same test
            // ARRANGE
            string expected = "abcd";
            

            // ACT
            var secString = StringEncrypter.ToSecureString(expected);
            string actual = StringEncrypter.ToInsecureString(secString);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToInsecureStringTest()
        {
            // Not really a proper test but can't do much else apart from recreate the actual function.
            // Have to test conversion to and from a secure string in the same test
            // ARRANGE
            string expected = "abcd";

            // ACT
            var secString = StringEncrypter.ToSecureString(expected);
            string actual = StringEncrypter.ToInsecureString(secString);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EncryptStringTest()
        {
            // Not really a proper test but can't do much else apart from recreate the actual function.
            // Have to test descryption of encrypted string and conversion from a secure string.
            // ARRANGE
            //string expected = "AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAA7ue1M1xszU6U+PIJOfKSSwAAAAACAAAAAAAQZgAAAAEAACAAAAD64gZAG/Da3QKF0mvmk+YyVp0O7TT7FLj0l+afJBVaRgAAAAAOgAAAAAIAACAAAADfFwUF/Y9GuHit3UhccyyHPRAPYsKIM7WQlt0TdUKqHhAAAADnGoOO32bjM6aD6kUUbl46QAAAACGZjTHtPkwyOy2/VxZOTRIN7HIYiCHXsDgIoe8LBo62RsB35zH/b6FDlJPnjgAlYTn0aAMVcEEyflU+K4v2JVU=";
            string expected = "test";

            // ACT
            var secString = StringEncrypter.ToSecureString(expected);
            string encryptedString = StringEncrypter.EncryptString(secString);
            var encryptedSecString = StringEncrypter.DecryptString(encryptedString);
            string actual = StringEncrypter.ToInsecureString(encryptedSecString);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DecryptStringTest()
        {
            // Not really a proper test but can't do much else apart from recreate the actual function.
            // Have to test descryption of encrypted string and conversion from a secure string.
            // ARRANGE
            string input = "AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAA7ue1M1xszU6U+PIJOfKSSwAAAAACAAAAAAAQZgAAAAEAACAAAAD64gZAG/Da3QKF0mvmk+YyVp0O7TT7FLj0l+afJBVaRgAAAAAOgAAAAAIAACAAAADfFwUF/Y9GuHit3UhccyyHPRAPYsKIM7WQlt0TdUKqHhAAAADnGoOO32bjM6aD6kUUbl46QAAAACGZjTHtPkwyOy2/VxZOTRIN7HIYiCHXsDgIoe8LBo62RsB35zH/b6FDlJPnjgAlYTn0aAMVcEEyflU+K4v2JVU=";
            string expected = "test";

            // ACT
            var secString = StringEncrypter.DecryptString(input);
            string actual = StringEncrypter.ToInsecureString(secString);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}