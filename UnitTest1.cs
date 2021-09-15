using NUnit.Framework;
using OpenQA.Selenium.Winium;

namespace WiniumDesktop2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Windows\System32\notepad.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\itvdn\Winium.Desktop.Driver\", options);
            driver.FindElementByClassName("Edit").SendKeys("Hello, World!");

            driver.Close();
        }

        [Test]
        public void TestSimpleApp()
        {
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"D:\SimpleApp\WpfApp.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\itvdn\Winium.Desktop.Driver\", options);
            driver.FindElementByName("btn").Click();

            

            driver.Close();
        }
    }
}