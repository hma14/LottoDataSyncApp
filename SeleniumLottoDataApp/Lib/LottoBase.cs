﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLottoDataApp.Lib
{

    public class LottoBase
    {
        public RemoteWebDriver Driver { get; set; }
        public LottoBase()
        {
            Driver = new ChromeDriver(); // Launches Browser for English version
            //Driver = new InternetExplorerDriver(@"F:\Visual_Studio_2015_Apps\SeleniumLottoDataApp\SeleniumLottoDataApp\"); // Launches Browser for English version
            //Driver = new EdgeDriver(@"F:\Visual_Studio_2015_Apps\SeleniumLottoDataApp\SeleniumLottoDataApp\"); // Launches Browser for English version

            //Driver.Manage().Window.Maximize(); // Maximizes Browser

            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(40));
        }

        internal virtual void InsertDb() { }
        public virtual void InsertDb(int drawNumber, string drawDate, string[] numbers) { }



        public IDictionary DicDate = new Dictionary<string, string>  {
                    { "January","1" },
                    { "February","2" },
                    { "March","3" },
                    { "April","4" },
                    { "May","5" },
                    { "June","6" },
                    { "July","7" },
                    { "August","8" },
                    { "September","9" },
                    { "October","10" },
                    { "November","11" },
                    { "December","12" }
        };

        public IDictionary DicDateShort = new Dictionary<string, string>  {
                    { "Jan","1" },
                    { "Feb","2" },
                    { "Mar","3" },
                    { "Apr","4" },
                    { "May","5" },
                    { "Jun","6" },
                    { "Jul","7" },
                    { "Aug","8" },
                    { "Sep","9" },
                    { "Oct","10" },
                    { "Nov","11" },
                    { "Dec","12" }
        };

        public IDictionary DicDateShort2 = new Dictionary<string, string> {
                    { "JAN","1" },
                    { "FEB","2" },
                    { "MAR","3" },
                    { "APR","4" },
                    { "MAY","5" },
                    { "JUN","6" },
                    { "JUL","7" },
                    { "AUG","8" },
                    { "SEP","9" },
                    { "OCT","10" },
                    { "NOV","11" },
                    { "DEC","12" }
        };


    }
}
