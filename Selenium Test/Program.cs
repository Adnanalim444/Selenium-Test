using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// See https://aka.ms/new-console-template for more information
var driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://pakistanistores.com/");
var elem = driver.FindElement(By.ClassName ("searchInput"));
elem.Clear();
elem.SendKeys("laptop");
//elem.SendKeys("laptop"+Keys.Enter );
driver.FindElement(By.ClassName("btn")).Click();
var elements = driver.FindElements(By.CssSelector("div.tF2Cxc"));
foreach(var elem1 in elements)
{
   // var h3 = elem1.FindElement(By.CssSelector("div.TbwUpd NJjxre")).Text;
    //var link = elem1.FindElement(By.CssSelector("h3.LC20lb MBeuO DKV0Md")).Text;

     //System.Console.WriteLine("div"+div);
     //System.Console.WriteLine("h3"+h3);
}
System.Console.ReadKey();
driver.Close();
driver.Quit();

