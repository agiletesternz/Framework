
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Global;

namespace Task.Test
{
    public abstract class Base
    {
        public static int Browser = Int32.Parse(TaskResource.Browser);
        public static string ExcelPath = TaskResource.ExcelPath;
        public static string ScreenshotPath = TaskResource.ScreenShotPath;
        public static string ReportPath = TaskResource.ReportPath;
        public static int RowCountBase = Int32.Parse(TaskResource.RowNum);
        public static int LoginBase = Int32.Parse(TaskResource.Login);

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        #endregion
        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
            switch (Browser)
            {
                case 1:
                    Driver.driver = new FirefoxDriver();
                    break;
                case 2:

                    var options = new ChromeOptions();

                    options.AddArguments("--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
                    options.AddUserProfilePreference("credentials_enable_service", false);
                    options.AddUserProfilePreference("profile.password_manager_enabled", false);
                    Driver.driver = new ChromeDriver(options);

                    //Driver.driver = new ChromeDriver();
                    //Driver.driver.Manage().Window.Maximize();
                    break;


            }
            extent = new ExtentReports(ReportPath, true, DisplayOrder.OldestFirst);
           extent.LoadConfig(TaskResource.ReportXMLPath);
        }
        [TearDown]
        public void TearDown()
        {
            //  // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Image example: " + img);
              // end test. (Reports)
              extent.EndTest(test);
            //  // calling Flush writes everything to the log file (Reports)
              extent.Flush();
            //  // Close the driver :)            
            //  //Driver.driver.Close();
            Driver.driver.Dispose();
        }

        #endregion
    }
    }