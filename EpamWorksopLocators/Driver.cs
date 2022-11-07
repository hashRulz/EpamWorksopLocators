using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EpamWorksopLocators
{
    public class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--start-maximized");
                driver = new ChromeDriver(chromeOptions);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            return driver;
        }

        public static void Close()
        {
            driver?.Quit();
            driver = null;
        }
    }
}
