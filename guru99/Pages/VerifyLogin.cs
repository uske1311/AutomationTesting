using OpenQA.Selenium;

namespace guru99.Pages
{
  public class VerifyLogin
  {
    IWebDriver _driver;
    public VerifyLogin(IWebDriver driver)
    {
      _driver = driver;
    }
    IWebElement ContinueButton => _driver.FindElement(By.CssSelector("a[data-qa='continue-button']"));

    public void ClickContinueButton()
    {
      ContinueButton.Click();
    }
  }
}