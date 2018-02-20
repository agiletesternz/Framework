using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task.Global;

namespace Task.Test
{
   public class ContactUs
    { 
   public static int RowCountBase = Int32.Parse(TaskResource.RowNum);
    internal void fillform()
    {
        #region

        //ExcelLib.PopulateInCollection(Base.ExcelPath, "Page");
        ExcelLib.PopulateInCollection(Base.ExcelPath, "Page");
        Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "url"));
        //  Driver.driver.Navigate().GoToUrl("https://qaautomation.co.nz/form1/");
        //Sending Firstname
        Driver.Textbox(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"), ExcelLib.ReadData(2, "FirstName"));
        //Sending LastNAme
        Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"), ExcelLib.ReadData(2, "LastName"));
        //Sending Email
        Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(2, "Email"));
        //Sending phone Number
        Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(2, "Phone"));

        //sending Subject
        Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(2, "Subject"));

        //sending Message
        Driver.Textbox(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"), ExcelLib.ReadData(2, "Message"));
        //click on submit butotm
        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "User can submit successfully");
        #endregion
        //    First name
        #region
        //var FirstName = Driver.driver.FindElement(By.XPath("//*[@id='hugeit_preview_textbox_15']"));
        //FirstName.SendKeys("Hi");
        ////Lastname

        //var LastName = Driver.driver.FindElement(By.XPath("//*[@id='hugeit_preview_textbox_14']"));
        //LastName.SendKeys("Hi");

        ////Email
        //var Email = Driver.driver.FindElement(By.XPath("//*[@id='hugeit_preview_textbox_20']"));
        //Email.SendKeys("abc@gmail.com");
        ////Phone
        //var Phone = Driver.driver.FindElement(By.XPath("//*[@id='hugeit_preview_textbox_19']"));
        //Phone.SendKeys("34343434343");
        ////Subject
        //var subject = Driver.driver.FindElement(By.XPath("//*[@id='hugeit_preview_textbox_18']"));
        //subject.SendKeys("sjkafjasjf");
        ////Message
        //var message = Driver.driver.FindElement(By.XPath("//*[@id='hugeit_preview_textbox_17']"));
        //message.SendKeys("ggkjsahfjhadjshfahfkjaf");
        //var button = Driver.driver.FindElement(By.XPath("//*[@id='hugeit_preview_button__submit_21']"));
        //button.Click();
        #endregion

    }
    internal void Validation()
    {
        ExcelLib.PopulateInCollection(Base.ExcelPath, "Page");

        //check if user can navigate to page
        Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "url"));
        string myrequest = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));
        if (myrequest == "Contact US Form")
        {
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "User navigate to contact detail");

        }
        //click on Submit button
        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
        Thread.Sleep(1000);
        //check if user can see validation msg for Firstname
        string Firstname = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
        if (Firstname == "Please Fill This Field")
        {
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "user can see validation msg for Firstname");

        }
        //check if user can see validation msg for Lastname
        string Lastname = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"));
        if (Lastname == "Please Fill This Field")
        {
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "user can see validation msg for Lastname");

        }

        //check if user can see validation msg for Email
        string Email = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));
        if (Email == "Please Fill This Field")
        {
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "user can see validation msg for Email");

        }
        // check if user can see validation msg for message
        string message = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"));
        if (message == "Please Fill This Field")
        {
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "user can see validation msg for Message");

        }
    }

}
}
