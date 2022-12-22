using OpenQA.Selenium;

namespace guru99.Pages;

public abstract class BasePage
{
    public readonly HeaderNavi headerNavi;
    public BasePage(IWebDriver driver)
    {
        headerNavi = new HeaderNavi(driver);
    }
}