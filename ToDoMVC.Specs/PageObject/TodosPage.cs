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
        public ChromeDriver Driver = new ChromeDriver();
        public void OpenToDosScreen()
        {
            Driver.Navigate().GoToUrl("http://todomvc.com/examples/react/#/");
        }
    }
}
