using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Email.Tests
{
    [TestFixture]
    public class InboxTests
    {
        [Test]
        public void OpenMail_FirstEmailSelected()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://purecss.io/layouts/email/#");
            EmailPage emailPage = new EmailPage(driver);
            var isSelected = emailPage.Mails.First().IsSelected;
            Assert.That(isSelected, Is.True);
            /*NOT USE: var isSelected = emailPage.IsFirstMailSelected();
            
            1. For each new proprty in a mail, need new method -find first,where, need to implement linq for each property
            Very long time of development and maintenence
            2. Long class(code smell) - what causes to many people stop using PageObject
            3. Conflicts with OOP principles (SRP) and object modelling, like in code and in DB
    
            But with good object modelling:
            1. Just add the proprty to Mail class and then each test can filter using LINQ methods on List
            2. Classes will not be longer because the details of mail were moved to Mail class
            3. Real OOP solution, with SRP in mind, exactly like in the code and DB
            
            emailPage.isMessageWithSubjectIsUnread("I like cheese");
            emailPage.isMessageWithBodyUnread("I like cheese");
            emailPage.isFirstMessageImportant();
            emailPage.isMessageImportantBySubject("I like cheese");
            emailPage.ClickMessageBySubject("I like cheese");
            emailPage.ClickMessageByIndex(0);

            emailPage.FindFirstImportantMessage();
            emailPage.FindUnreadMessages();
            */

            //Do not expose the internal of the page!!!
            //NOT !!! emailPage.MailList.First().Selected
        }
    }

    public class EmailPage
    {
        private readonly IWebDriver _driver;

        public EmailPage(IWebDriver driver)
        {
            _driver = driver;
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(a => a.Title== "Email – Layout Examples – Pure");
        }

        //Do not expose the internal of the page!!!
        //public IList<IWebElement> MailList => _driver.FindElements(null);
        private IList<IWebElement> MailElements => _driver.FindElements(By.CssSelector(".email-item"));

        public List<MailPageObject> Mails
        {
            get
            {
                //List<MailPageObject> list = new List<MailPageObject>();
                //foreach (var mailElement in MailElements)
                //{
                //    var mailPO = new MailPageObject(mailElement);
                //    list.Add(mailPO);
                //}
                //return list;
                return MailElements.Select(element => new MailPageObject(element)).ToList();
            }
        }
    }

    public class MailPageObject
    {
        private readonly IWebElement _mailElement;

        public MailPageObject(IWebElement mailElement)
        {
            _mailElement = mailElement;
        }

        public bool IsSelected
        {
            get
            {
                //var className = _mailElement.GetAttribute("class");
                //return className.Contains("selected");
                return _mailElement.GetAttribute("class").Contains("selected");
            }
        }
    }
}