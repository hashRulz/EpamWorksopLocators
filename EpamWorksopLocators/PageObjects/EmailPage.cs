using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamWorksopLocators.PageObjects
{
    public class EmailPage : BasePage
    {
        public EmailPage() : base("")
        {
        }

        public IWebElement UsernameField => Driver.GetInstance().FindElement(By.XPath("//input[@id='identifierId']"));
        public WebElement PasswordField => (WebElement)Driver.GetInstance().FindElement(By.XPath("//*[@id=\"password\"]/div[1]/div/div[1]/input"));
        public IWebElement LoginButton => Driver.GetInstance().FindElement(By.XPath("//span[contains(text(),'Next')]"));
        public IWebElement LoginButton2 => Driver.GetInstance().FindElement(By.XPath("//*[@id=\"passwordNext\"]/div/button"));

        public IWebElement ComposeButton => Driver.GetInstance().FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div/div"));
        public IWebElement To => Driver.GetInstance().FindElement(By.XPath("//input[@peoplekit-id='BbVjBd']"));
        public IWebElement Subject => Driver.GetInstance().FindElement(By.XPath("//input[@aria-label='Subject']"));
        public IWebElement Close => Driver.GetInstance().FindElement(By.XPath("//*[@id=\":5h\"]"));



        public void Login(string username, string password)
        {
            UsernameField.SendKeys(username);
            LoginButton.Click();
            PasswordField.SendKeys(password);
            LoginButton2.Click();

        }
        public void SaveMail(string username, string password)
        {
            ComposeButton.Click();
            
            Subject.SendKeys(password);
            To.SendKeys(username);
            Close.Click();

        }
    }
}
