using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamWorksopLocators.PageObjects
{
    public abstract class BasePage
    {
        private readonly string host = "https://mail.google.com";
        private readonly string url;

        protected BasePage(string url)
        {
            this.url = url;
        }

        public void Open()
        {
            Driver.GetInstance().Navigate().GoToUrl(host + url);
        }
    }
    
    //comment
}
