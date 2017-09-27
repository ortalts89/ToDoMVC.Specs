using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using ToDoMVC.Specs.PageObject;


namespace ToDoMVC.Specs.Steps
{
    [Binding]
    public sealed class NewTaskSteps
    {
        public TodosPage TodosPage = new TodosPage();

       

        [Given(@"i have open the todos screen")]
        public void GivenIHaveOpenTheTodosScreen()
        {
            TodosPage.OpenToDosScreen();
        }

        [When(@"i add new task")]
        public void WhenIAddNewTask()
        {
            //AddNewTask();
        }



    }
}
