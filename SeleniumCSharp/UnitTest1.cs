using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumCSharp
{
	public class Tests
	{

		IWebDriver driver;
		String test_url = "https://tiinatamkivi22.thkit.ee/";
		private readonly Random _random = new Random();

		[SetUp]
		public void start_browser()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
		}

		[Test]
		public void test_page1()
		{
			driver.Url = test_url;
			driver.Navigate().GoToUrl("https://tiinatamkivi22.thkit.ee/");

			try { IWebElement sButton2 = driver.FindElement(By.XPath("//*[@id=\"menu-item-633\"]")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(2500);
    //        for (int a = 0; a < 1; a++)
				//{
				//	Thread.Sleep(2500);
				//	var sRadio = driver.FindElements(By.XPath("//*[@id='menu-item-626']"));
				//	for (int i = 0; i < sRadio.Count; i++)
				//	{
				//		var els = sRadio[i].FindElements(By.XPath(".//input[@type='menu']"));
				//		if (els.Count >= 2)
				//		{
				//			try { els[_random.Next(0, els.Count)].Click(); } catch (Exception) { }
				//		}
				//	}
				//	var sText = driver.FindElements(By.XPath("//input[@type='text']"));
				//	for (int i = 0; i < sText.Count; i++)
				//	{
				//		try { sText[i].Click(); sText[i].SendKeys("Lappolainen"); } catch (Exception) { }
				//	}
				//	var sTextArea = driver.FindElements(By.XPath("//textarea"));
				//	for (int i = 0; i < sTextArea.Count; i++)
				//	{
				//		try { sTextArea[i].Click(); sTextArea[i].SendKeys("LappolainenMartin"); } catch (Exception) { }
				//	}
				//	var sNum = driver.FindElements(By.XPath("//input[@type='number']"));
				//	for (int i = 0; i < sNum.Count; i++)
				//	{
				//		try { sNum[i].Click(); sNum[i].SendKeys("1"); } catch (Exception) { }
				//	}
				//	var sSelect = driver.FindElements(By.XPath("//select"));
				//	for (int i = 0; i < sNum.Count; i++)
				//	{
				//		try { sSelect[i].Click(); sSelect[i].FindElements(By.XPath(".//*"))[2].Click(); } catch (Exception) { }
				//	}

				//	IWebElement sButtonE = driver.FindElement(By.XPath("//*[@value='Sauvegarder brouillon']"));
				//	try { sButtonE.Click(); } catch (Exception) { }
				//	Thread.Sleep(2500);
				//	IWebElement sButton = driver.FindElement(By.XPath("//*[@value='Suivant']"));
				//	try { sButton.Click(); } catch (Exception) { }
				//}
				//Thread.Sleep(2500);

				//IWebElement sButton3 = driver.FindElement(By.XPath("//*[@value='Finaliser']"));
				//try { sButton3.Click(); } catch (Exception) { }

				//Thread.Sleep(2500);

				//IWebElement sButton4 = driver.FindElement(By.XPath("//a[@href='/user/login']"));
				//try { sButton4.Click(); } catch (Exception) { }

				//Thread.Sleep(2500);

				//IWebElement sButton5 = driver.FindElement(By.XPath("//*[@value='Se connecter']"));
				//try { sButton5.Click(); } catch (Exception) { }
				//Thread.Sleep(8000);
			}

		[Test]
		public void test_page2()
		{
			driver.Url = test_url;
			driver.Navigate().GoToUrl("https://tiinatamkivi22.thkit.ee/");

			try { IWebElement sButton2 = driver.FindElement(By.XPath("//*[@id=\"menu-item-625\"]")); sButton2.Click(); } catch (Exception) { }
			Thread.Sleep(2500);
		}


		[Test]
		public void test_page3()
		{
			driver.Url = test_url;
			driver.Navigate().GoToUrl("https://tiinatamkivi22.thkit.ee/");

			try { IWebElement sButton2 = driver.FindElement(By.XPath("//*[@id=\"menu-item-150\"]")); sButton2.Click(); } catch (Exception) { }
			Thread.Sleep(2500);


			var sText = driver.FindElements(By.XPath("//*[@id=\"wpforms-617-field_0\"]"));
			for (int i = 0; i < sText.Count; i++)
			{
				try { sText[i].Click(); sText[i].SendKeys("Tiina"); } catch (Exception) { }
			}
			Thread.Sleep(2500);
			var sTextArea = driver.FindElements(By.XPath("//*[@id=\"wpforms-617-field_1\"]"));
			for (int i = 0; i < sTextArea.Count; i++)
			{
				try { sTextArea[i].Click(); sTextArea[i].SendKeys("tiinake@email.ee"); } catch (Exception) { }
			}
			Thread.Sleep(2500);
			var sTextArea1 = driver.FindElements(By.XPath("//*[@id=\"wpforms-617-field_2\"]"));
			for (int i = 0; i < sTextArea1.Count; i++)
			{
				try { sTextArea1[i].Click(); sTextArea1[i].SendKeys("Tere-tere vana kere"); } catch (Exception) { }
			}
			Thread.Sleep(2500);

		}


        [Test]
        public void test_page4()
        {
            driver.Url = test_url;
            driver.Navigate().GoToUrl("https://tiinatamkivi22.thkit.ee/");

            try { IWebElement sButton1 = driver.FindElement(By.XPath("//*[@id=\"menu-item-633\"]/a")); sButton1.Click(); } catch (Exception) { }
            Thread.Sleep(2500);

            try { IWebElement sButton2 = driver.FindElement(By.XPath("//*[@id=\"uc_post_list_elementor_93592e9\"]/div[1]/div[2]/div")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(2500);

            try { IWebElement sButton3 = driver.FindElement(By.XPath("//*[@id=\"uc_post_list_elementor_93592e9\"]/div[1]/div[2]/div/div[1]/a")); sButton3.Click(); } catch (Exception) { }
            Thread.Sleep(2500);

        }





        [TearDown]
			public void close_Browser()
			{
				driver.Quit();
			}
		}
	}
