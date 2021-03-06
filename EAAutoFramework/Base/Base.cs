﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAAutoFramework.Base
{
    public class Base
    {
        public BasePage CurrentPage { get; set; }

        private IWebDriver _driver { get; set; }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <typeparam name="TPage">The type of the page.</typeparam>
        /// <returns></returns>
        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };

            PageFactory.InitElements(DriverContext.Driver, pageInstance);

            return pageInstance;
        }

        /// <summary>
        /// Return Page instance.
        /// </summary>
        /// <typeparam name="TPage">The type of the page.</typeparam>
        /// <returns></returns>
        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
