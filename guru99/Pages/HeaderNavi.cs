using OpenQA.Selenium;

namespace guru99.Pages
{
  public class HeaderNavi
  {
    IWebDriver _driver;

    public HeaderNavi(IWebDriver driver)
    {
      _driver = driver;
    }
    public IWebElement SgnUpAndLogLink => _driver.FindElement(By.CssSelector("a[href='/login']"));
    public IWebElement LogoutButton => _driver.FindElement(By.CssSelector("a[href='/logout']"));

    public void GoToSignUpLoginPage()
    {
      SgnUpAndLogLink.Click();
    }
    public void Logout()
    {
      LogoutButton.Click();
    }
  }
}