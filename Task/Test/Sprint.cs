
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Test
{
    class Sprint
    {
        [TestFixture]
        [Category("Sprint")]
        class Sprint_1_Administration : Base
        {

          
            [Test]
            public void ContactForm()
            {
                test = extent.StartTest("check if user able to submit Contact details successfully");
                ContactUs cu = new ContactUs();
                cu.fillform();
            }
            [Test]
            public void ContactFormValidation()
            {
                test = extent.StartTest("check if user is able to see validation message");
                ContactUs cu = new ContactUs();
                cu.Validation();
            }

        }
    }
}
