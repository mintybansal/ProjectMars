﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace Mars.Helpers
{
    public class LoginPage
    {
        public static void LoginStep()
        {
            Driver.NavigateUrl();
            Thread.Sleep(1000);

            //click on signin 
            Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();
            
            ExcelData.PopulateInCollection(@"C:\Users\minty\OneDrive\Documents\onboarding\Mars\Data\TestData.xlsx", "LoginDetails");
            //Enter Username
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys(ExcelData.ReadData(2, "Username"));
           // Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys(x1Range.Cells[2][1]);

            //Enter password
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys(ExcelData.ReadData(2, "Password"));
            //Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys(x1Range.Cells[2][2]);
            Thread.Sleep(1000);

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
        }
    }
}
