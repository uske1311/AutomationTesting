using OpenQA.Selenium;

namespace guru99.Pages
{
  public class SignUpPage
  {
    IWebDriver _driver;
    public SignUpPage(IWebDriver driver)
    {
      _driver = driver;
    }
    public IWebElement password => _driver.FindElement(By.CssSelector("input[type='password']"));
    public IWebElement birtDay => _driver.FindElement(By.CssSelector("#days"));
    public IWebElement birthDay1 => _driver.FindElement(By.CssSelector("#days > option:nth-child(2)"));
    public IWebElement month => _driver.FindElement(By.CssSelector("#months"));
    public IWebElement month1 => _driver.FindElement(By.CssSelector("#months > option:nth-child(2)"));
    public IWebElement year => _driver.FindElement(By.CssSelector("#years"));
    public IWebElement year1 => _driver.FindElement(By.CssSelector("#years > option:nth-child(2)"));
    public IWebElement firstName => _driver.FindElement(By.Id("first_name"));
    public IWebElement lastName => _driver.FindElement(By.Id("last_name"));
    public IWebElement Address => _driver.FindElement(By.Id("address1"));
    public IWebElement Country => _driver.FindElement(By.CssSelector("#country"));
    public IWebElement Country1 => _driver.FindElement(By.CssSelector("#country > option:nth-child(1)"));
    public IWebElement State => _driver.FindElement(By.CssSelector("input[data-qa='state']"));
    public IWebElement City => _driver.FindElement(By.CssSelector("input[data-qa='city']"));
    public IWebElement ZipCode => _driver.FindElement(By.CssSelector("input[data-qa='zipcode']"));
    public IWebElement MobileNum => _driver.FindElement(By.CssSelector("input[data-qa='mobile_number']"));
    public IWebElement creatAccBtn => _driver.FindElement(By.CssSelector("button[data-qa='create-account']"));

    public void enterRequiredCredentials(string pass, string fname, string lname, string address,string state,string city, string zipcode, string mobileNum)
    {
      password.SendKeys(pass);
      birtDay.Click();
      birthDay1.Click();
      month.Click();
      month1.Click();
      year.Click();
      year1.Click();
      firstName.SendKeys(fname);
      lastName.SendKeys(lname);
      Address.SendKeys(address);
      Country.Click();
      Country1.Click();
      State.SendKeys(state);
      City.SendKeys(city);
      ZipCode.SendKeys(zipcode);
      MobileNum.SendKeys(mobileNum);
      creatAccBtn.Click();
    }

  } 
}