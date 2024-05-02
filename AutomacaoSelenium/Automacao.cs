using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace ProjetoSelenium;

public static class Automacao
{
    public static void Main()
    {
        var drive = new ChromeDriver();

        Actions acoes = new Actions(drive);

        drive.Navigate().GoToUrl("https://app.izzyway.com.br/Account/Login");

        drive.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        drive.FindElement(By.XPath("/html/body/div/div/div/div/div[2]/form/div[1]/div/input")).Click();

        drive.FindElement(By.XPath("/html/body/div/div/div/div/div[2]/form/div[1]/div/input")).SendKeys("email");

        drive.FindElement(By.XPath("/html/body/div/div/div/div/div[2]/form/div[2]/div/input")).Click();

        drive.FindElement(By.XPath("/html/body/div/div/div/div/div[2]/form/div[2]/div/input")).SendKeys("senha");

        drive.FindElement(By.XPath("/html/body/div/div/div/div/div[2]/form/div[3]/input")).Click();

        drive.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(20));
        wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/span")));

        acoes.SendKeys(Keys.F2).Perform();

        drive.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/span")).Click();

        drive.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div/span")).SendKeys("Caixa");

        acoes.SendKeys(Keys.Enter).Perform();

    }

}

