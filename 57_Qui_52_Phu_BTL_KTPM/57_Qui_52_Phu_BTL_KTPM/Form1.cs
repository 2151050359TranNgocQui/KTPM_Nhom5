using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using System.Timers;

namespace _57_Qui_52_Phu_BTL_KTPM
{
    public partial class Form1 : Form
    {
        //_57_Qui_52_Phu
        private IWebDriver driver;

        private const string webURL = "https://www.linkedin.com/";

        //_57_Qui_52_Phu
        private void useProfile()
        {
            //_57_Qui_52_Phu
            var options = new ChromeOptions();
            options.AddArgument("user-data-dir=C:\\Users\\Admin\\AppData\\Local\\Google\\Chrome\\User Data");
            options.AddArgument("profile-directory=Default");

            driver = new ChromeDriver(options);
        }

        //_57_Qui_52_Phu
        public Form1()
        {
            InitializeComponent();
            useProfile();
        }

        //_57_Qui_52_Phu
        private void navigate()
        {
            driver.Navigate().GoToUrl(webURL);
        }

        private void signIn()
        { 
            IWebElement signin = driver.FindElement(By.XPath("//*[@id='main-content']/section[1]/div/div/form/div[2]/button"));
            signin.Click();
        }

        private void bnCommentTestCase_Click(object sender, EventArgs e)
        {
            navigate();
        }
    }
}
