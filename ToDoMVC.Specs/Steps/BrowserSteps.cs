using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ToDoMVC.Specs.Steps
{
    [Binding]
    public sealed class BrowserSteps : TechTalk.SpecFlow.Steps
    {
        private IWebDriver driver => ScenarioContext.Get<IWebDriver>("driver");
    }
}