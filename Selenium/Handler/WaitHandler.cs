namespace Selenium.Handler;

/*
 * Clase para manejar las esperas explicitas
 */
public class WaitHandler
{
    //Método para esperar por un elemento presente en la página web
    //Retorna true si se encuentra el elemento el máximo 3 segundos si no retorna falso 
    public static bool ElementIsPresent(IWebDriver driver, By locator)
    {
        try
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            wait.Until(drv => drv.FindElement(locator));
            return true;
        }

        catch { }
        return false;
    }
}
