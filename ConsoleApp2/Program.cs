
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		private static int body;

		static void Main(string[] args)
		{
			// Create Employee

			//Go to Url
			IWebDriver driver = new ChromeDriver(@"C:\Users\Rajesh Jasti\Downloads\chromedriver");
			driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

			//Enter USer Name
			IWebElement UserName = driver.FindElement(By.XPath("//*[@id='UserName']"));
			UserName.SendKeys("hari");

			//Enter Password

			IWebElement password = driver.FindElement(By.XPath("//*[@id='Password']"));
			password.SendKeys("123123");

			// Enter Login

			IWebElement login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
			login.Click();

			//Check if home page is displayed

			if (driver.FindElement(By.XPath("/html/body/div[3]/div/a")).Text == "TurnUp")

			{
				Console.WriteLine("Logged in Successfully,Test Pased");
			}
			else

			{
				Console.WriteLine("Login fail");
			}
			//Administrator
			IWebElement Administrator = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
			Administrator.Click();

			//Go to Employee
			IWebElement Employee = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
			Employee.Click();

			//Crate new Employee 

			IWebElement Create = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
			Create.Click();

			IWebElement Name = driver.FindElement(By.XPath("//*[@id='Name']"));
			Name.SendKeys("Industry");

			IWebElement userName = driver.FindElement(By.XPath("//*[@id='Username']"));
			userName.SendKeys("Connect");

			IWebElement Contact = driver.FindElement(By.XPath("//*[@id='ContactDisplay']"));
			Contact.SendKeys("0123456789");

			IWebElement Password = driver.FindElement(By.XPath("//*[@id='Password']"));
			Password.SendKeys("Abcd@123)");

			IWebElement RetypePassword = driver.FindElement(By.XPath("//*[@id='RetypePassword']"));
			RetypePassword.SendKeys("Abcd@123)");

			IWebElement Save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
			Save.Click();

			IWebElement BackToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
			BackToList.Click();


			if (driver.FindElement(By.XPath("//*[@id='container']/p/a")).Text == "Create")
			{
				Console.WriteLine("Employee Created Successfully");
			}
			else

			{
				Console.WriteLine("Fail to create Employee");

			}

			
		}

	}
}
