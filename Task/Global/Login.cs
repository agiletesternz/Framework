using Task.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task.Test;

namespace Task.Global
{
    class Login
    {
        //public static int LoginBase = Int32.Parse(TaskResource.Login);
        public static int LoginBase = Int32.Parse(TaskResource.Login);

        internal void LoginSuccessfull()
        {

            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Page");

            // Navigating to Login page using value from Excel
            Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(LoginBase, "url"));

            

        }
    }
}
