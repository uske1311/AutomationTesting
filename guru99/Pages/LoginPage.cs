using OpenQA.Selenium;

namespace guru99.Pages
{
  public class SignUp
  {
    IWebDriver _driver;

    public SignUp(IWebDriver driver)
    {
      _driver = driver;
    }
    IWebElement SignUpNameField => _driver.FindElement(By.CssSelector("input[data-qa='signup-name']"));
    IWebElement SignUpEmailField => _driver.FindElement(By.CssSelector($"input[data-qa='signup-email']"));
    IWebElement signupButton => _driver.FindElement(By.CssSelector("button[data-qa='signup-button']"));
    IWebElement LoginEmail => _driver.FindElement(By.CssSelector("input[data-qa='login-email']"));
    IWebElement LoginPassword => _driver.FindElement(By.CssSelector("input[data-qa='login-password']"));
    IWebElement LoginButton => _driver.FindElement(By.CssSelector("button[data-qa='login-button']"));

    public void EnterName(string name)
    {
      SignUpNameField.SendKeys(name);
    }
    public void EnterEmail(string email)
    {
      SignUpEmailField.SendKeys(email);
    }
    public void ClickSignUp()
    {
      signupButton.Click();
    }
    public void Login(string email,string password)
    {
      LoginEmail.SendKeys(email);
      LoginPassword.SendKeys(password);
      LoginButton.Click();
    }

    

  }
}