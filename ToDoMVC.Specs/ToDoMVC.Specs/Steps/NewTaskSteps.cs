﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;
using ToDoMVC.Specs.PageObject;


namespace ToDoMVC.Specs.Steps
{
    [Binding]
    public sealed class NewTaskSteps : TechTalk.SpecFlow.Steps
    {
        private IWebDriver driver => ScenarioContext.Get<IWebDriver>("driver");
        public TodosPage TodosPage { get; set; }

        [Given(@"i have open the todos screen")]
        public void GivenIHaveOpenTheTodosScreen()
        {
            TodosPage = TodosPage.OpenToDosScreen(driver);
        }

        [When(@"i add new task")]
        public void WhenIAddNewTask()
        {
            TodosPage.AddNewTask();
        }

        [Then(@"the task will be added to the end of the tasks list")]
        public void ThenTheTaskWillBeAddedToTheEndOfTheTasksList()
        {
            TodosPage.Tasks.Last();
        }

    }
}
