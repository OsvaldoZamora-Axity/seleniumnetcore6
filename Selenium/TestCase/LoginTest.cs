namespace Selenium.TestCase;

/*
 * Clase que contiene los casos de prueba para el Login
 */
//Anotación de NUnit para marcar una clase que contenga casos de prueba
[TestFixture] 
public class LoginTest
{
    //Selenium Driver
    protected IWebDriver Driver;

    //SetUp: Anotación de NUnit para ejecutar un método antes de cada test
    //Método para iniciar el navegador Chrome y navegar a una URL
    [SetUp]
    public void BeforeTest()
    {
        Driver = new ChromeDriver();
        Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    }

    //Test: Anotación de NUnit para marcar a un método como un caso de prueba automatizado
    //Método que implementa el caso de prueba del Login. El resultado esperado es que el usuario se loguee correctamente
    [Test]
    public void SuccesfulLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        EmployeePage employeePage = loginPage.LoginAs("standard_user", "secret_sauce");

        Assert.IsTrue(employeePage.FormIsPresent());
    }

    //TearDown: Anotación de NUnit para ejecutar un metodo después de cada test
    //Método para cerrar el navegador
    [TearDown]
    public void AfterTest()
    {
        Driver?.Dispose();
        return;
    }

}
