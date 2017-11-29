using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ToDoMVC.Specs.PageObject
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Element(string xpath = "", string css = "", string id = "")
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            By by = null;
            if (xpath != "")
                by = By.XPath(xpath);
            if (css != "")
                by = By.CssSelector(css);
            if (id != "")
                by = By.Id(id);
            var element = wait.Until(ExpectedConditions.ElementIsVisible(by));
            return element;
        }
    }
}
