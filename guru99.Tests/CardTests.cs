using guru99.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace guru99.Tests;

public class CardTests
{
    IWebDriver driver;
 
    [SetUp]
    public void BeforEach()
    {   
        driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
        driver.Url = ("https://automationexercise.com/");
        driver.Manage().Window.Maximize();
    }
    [TearDown]
    public void AfterEach()
    {
        driver.Quit();
    }
    [Test]
    public void SignUpTest()
    {   
        string name = "tare";
        string email = "uska13@gmail.com";
        string pass = "tarik123";
        string fname = "tarik";
        string lname = "ustovic";
        string zipcode = "123";
        string city = "Sarajevo";
        string address = "sedrenik";
        string mobileNum = "12345";
        string state = "BiH";
        var headerNavi = new HeaderNavi(driver);
        headerNavi.GoToSignUpLoginPage();
        var signUpPage = new SignUp(driver);
        signUpPage.EnterName(name);
        signUpPage.EnterEmail(email);
        signUpPage.ClickSignUp();
        new SignUpPage(driver).enterRequiredCredentials(pass,fname,lname,zipcode,city,address,mobileNum,state);
        new VerifyLogin(driver).ClickContinueButton();
        headerNavi.Logout();    
    }
    [Test]
    public void LoginTest()
    {
        string email = "uske@gmail.com";
        string pass = "tarik123";

        new HeaderNavi(driver).GoToSignUpLoginPage();
        var login = new SignUp(driver);
        login.Login(email, pass);
    }
}

