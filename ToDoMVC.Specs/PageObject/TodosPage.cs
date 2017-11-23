using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ToDoMVC.Specs.Steps;

namespace ToDoMVC.Specs.PageObject
{
    public class TodosPage : BasePage
    {
        public TodosPage(IWebDriver driver) : base(driver)
        {
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

        private IWebElement AddNewTaskTextBox => Element(css: "input[class='new-todo']");
        public List<TaskRow> Tasks { get; set; }


        public TodosPage AddNewTask()
        {
            AddNewTaskTextBox.Clear();
            AddNewTaskTextBox.SendKeys("Run Automation");
            AddNewTaskTextBox.SendKeys(Keys.Enter);
            return this;
        }
    }
}