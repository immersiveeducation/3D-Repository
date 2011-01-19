﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DR_Testing
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using NUnit.Framework;

    using Selenium;

    namespace UserReview
    {
        [TestFixture]
        public class FF_UserReview
        {
            protected ISelenium selenium;
            protected StringBuilder verificationErrors;


            private string path;

            [SetUp]
            virtual public void SetupTest()
            {
                selenium = new DefaultSelenium("localhost", 4444, "*chrome", Properties.Settings.Default._3DRURL);
                selenium.Start();
                verificationErrors = new StringBuilder();
            }

            [TearDown]
            public void TeardownTest()
            {
                try
                {
                    selenium.Stop();
                }
                catch (Exception)
                {
                    // Ignore errors if unable to close the browser
                }
                Assert.AreEqual("", verificationErrors.ToString());
            }

            [Test]
            virtual public void UserReview(
                 [Values(
                 "duffle_bag.zip"

                 )] 
                string mFileToUpload
                )
            {
                path = Properties.Settings.Default.ContentPath;
                if (mFileToUpload == "")
                    return;
                selenium.Open("/Default.aspx");

                if (selenium.IsTextPresent("Sign In"))
                {
                    selenium.Click("ctl00_LoginStatus1");
                    selenium.WaitForPageToLoad("30000");
                    selenium.Type("ctl00_ContentPlaceHolder1_Login1_Login1_UserName", Properties.Settings.Default._3DRUserName);
                    selenium.Type("ctl00_ContentPlaceHolder1_Login1_Login1_Password", Properties.Settings.Default._3DRPassword);
                    selenium.Click("ctl00_ContentPlaceHolder1_Login1_Login1_LoginButton");
                }
                selenium.WaitForPageToLoad("30000");
                selenium.Open("/Users/Upload.aspx");
                selenium.WaitForPageToLoad("30000");
                selenium.Type("ctl00_ContentPlaceHolder1_Upload1_TitleTextBox", "UserReview Test: "  +  System.DateTime.Now.ToString());
                selenium.Type("ctl00_ContentPlaceHolder1_Upload1_ContentFileUpload", path + mFileToUpload);
                selenium.Click("ctl00_ContentPlaceHolder1_Upload1_Step1NextButton");
                selenium.WaitForPageToLoad("300000");
                selenium.WaitForCondition("window.GetLoadingComplete != undefined", "20000");
                int count = 0;
                while ((selenium.GetEval("window.GetLoadingComplete() == true") != "true" && count < 30))
                {
                    count++;
                    System.Threading.Thread.Sleep(1000);

                }

                NUnit.Framework.Assert.AreEqual(selenium.GetEval("window.GetLoadingComplete() == true"), "true");


                

                selenium.Click("ctl00_ContentPlaceHolder1_Upload1_ValidationViewSubmitButton");
                selenium.WaitForPageToLoad("30000");
                selenium.Click("//div[@id='ctl00_ContentPlaceHolder1_ViewOptionsTab']/div/ul/li[2]/a/span/span/span");
                selenium.WaitForCondition("window.GetLoadingComplete != undefined", "20000");
                count = 0;
                while ((selenium.GetEval("window.GetLoadingComplete() == true") != "true" && count < 30))
                {
                    count++;
                    System.Threading.Thread.Sleep(1000);
                }

                string reviewstring = DateTime.Now.ToString() + " Automatic test review";
                selenium.Type("ctl00_ContentPlaceHolder1_ratingText", reviewstring);
                selenium.Click("ctl00_ContentPlaceHolder1_submitRating");
                selenium.WaitForPageToLoad("30000");

                NUnit.Framework.Assert.IsTrue(selenium.IsTextPresent(reviewstring));

            }
        }
    }

}
