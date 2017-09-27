using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ToDoMVC.Specs
{
    [Binding]
    public sealed class Hooks : TechTalk.SpecFlow.Steps
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeScenario]
        public void BeforeScenario()
        {
            var driver = new ChromeDriver();
            ScenarioContext.Add("driver",driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
