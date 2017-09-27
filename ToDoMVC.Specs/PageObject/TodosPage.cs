using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace ToDoMVC.Specs.PageObject
{
    public class TodosPage
    {
        private IWebDriver driver;

        public TodosPage(IWebDriver driver)
        {
            this.driver = driver;
            // Check that we're on the right page.
            if (driver.Title != "React • TodoMVC")
            {
                // Alternatively, we could navigate to the login page, perhaps logging out first
                throw new NotFoundException("This is not the login page");
            }
        }
        
        public static TodosPage OpenToDosScreen(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://todomvc.com/examples/react/#/");
            return new TodosPage(driver);
        }
    }
}