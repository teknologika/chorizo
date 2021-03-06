﻿/*Apache License
Version 2.0, January 2004
http://www.apache.org/licenses/

TERMS AND CONDITIONS FOR USE, REPRODUCTION, AND DISTRIBUTION

1. Definitions.

"License" shall mean the terms and conditions for use, reproduction, and distribution as defined by Sections 1 through 9 of this document.

"Licensor" shall mean the copyright owner or entity authorized by the copyright owner that is granting the License.

"Legal Entity" shall mean the union of the acting entity and all other entities that control, are controlled by, or are under common control with that entity. For the purposes of this definition, "control" means (i) the power, direct or indirect, to cause the direction or management of such entity, whether by contract or otherwise, or (ii) ownership of fifty percent (50%) or more of the outstanding shares, or (iii) beneficial ownership of such entity.

"You" (or "Your") shall mean an individual or Legal Entity exercising permissions granted by this License.

"Source" form shall mean the preferred form for making modifications, including but not limited to software source code, documentation source, and configuration files.

"Object" form shall mean any form resulting from mechanical transformation or translation of a Source form, including but not limited to compiled object code, generated documentation, and conversions to other media types.

"Work" shall mean the work of authorship, whether in Source or Object form, made available under the License, as indicated by a copyright notice that is included in or attached to the work (an example is provided in the Appendix below).

"Derivative Works" shall mean any work, whether in Source or Object form, that is based on (or derived from) the Work and for which the editorial revisions, annotations, elaborations, or other modifications represent, as a whole, an original work of authorship. For the purposes of this License, Derivative Works shall not include works that remain separable from, or merely link (or bind by name) to the interfaces of, the Work and Derivative Works thereof.

"Contribution" shall mean any work of authorship, including the original version of the Work and any modifications or additions to that Work or Derivative Works thereof, that is intentionally submitted to Licensor for inclusion in the Work by the copyright owner or by an individual or Legal Entity authorized to submit on behalf of the copyright owner. For the purposes of this definition, "submitted" means any form of electronic, verbal, or written communication sent to the Licensor or its representatives, including but not limited to communication on electronic mailing lists, source code control systems, and issue tracking systems that are managed by, or on behalf of, the Licensor for the purpose of discussing and improving the Work, but excluding communication that is conspicuously marked or otherwise designated in writing by the copyright owner as "Not a Contribution."

"Contributor" shall mean Licensor and any individual or Legal Entity on behalf of whom a Contribution has been received by Licensor and subsequently incorporated within the Work.

2. Grant of Copyright License.

Subject to the terms and conditions of this License, each Contributor hereby grants to You a perpetual, worldwide, non-exclusive, no-charge, royalty-free, irrevocable copyright license to reproduce, prepare Derivative Works of, publicly display, publicly perform, sublicense, and distribute the Work and such Derivative Works in Source or Object form.

3. Grant of Patent License.

Subject to the terms and conditions of this License, each Contributor hereby grants to You a perpetual, worldwide, non-exclusive, no-charge, royalty-free, irrevocable (except as stated in this section) patent license to make, have made, use, offer to sell, sell, import, and otherwise transfer the Work, where such license applies only to those patent claims licensable by such Contributor that are necessarily infringed by their Contribution(s) alone or by combination of their Contribution(s) with the Work to which such Contribution(s) was submitted. If You institute patent litigation against any entity (including a cross-claim or counterclaim in a lawsuit) alleging that the Work or a Contribution incorporated within the Work constitutes direct or contributory patent infringement, then any patent licenses granted to You under this License for that Work shall terminate as of the date such litigation is filed.

4. Redistribution.

You may reproduce and distribute copies of the Work or Derivative Works thereof in any medium, with or without modifications, and in Source or Object form, provided that You meet the following conditions:

1. You must give any other recipients of the Work or Derivative Works a copy of this License; and

2. You must cause any modified files to carry prominent notices stating that You changed the files; and

3. You must retain, in the Source form of any Derivative Works that You distribute, all copyright, patent, trademark, and attribution notices from the Source form of the Work, excluding those notices that do not pertain to any part of the Derivative Works; and

4. If the Work includes a "NOTICE" text file as part of its distribution, then any Derivative Works that You distribute must include a readable copy of the attribution notices contained within such NOTICE file, excluding those notices that do not pertain to any part of the Derivative Works, in at least one of the following places: within a NOTICE text file distributed as part of the Derivative Works; within the Source form or documentation, if provided along with the Derivative Works; or, within a display generated by the Derivative Works, if and wherever such third-party notices normally appear. The contents of the NOTICE file are for informational purposes only and do not modify the License. You may add Your own attribution notices within Derivative Works that You distribute, alongside or as an addendum to the NOTICE text from the Work, provided that such additional attribution notices cannot be construed as modifying the License.

You may add Your own copyright statement to Your modifications and may provide additional or different license terms and conditions for use, reproduction, or distribution of Your modifications, or for any such Derivative Works as a whole, provided Your use, reproduction, and distribution of the Work otherwise complies with the conditions stated in this License.

5. Submission of Contributions.

Unless You explicitly state otherwise, any Contribution intentionally submitted for inclusion in the Work by You to the Licensor shall be under the terms and conditions of this License, without any additional terms or conditions. Notwithstanding the above, nothing herein shall supersede or modify the terms of any separate license agreement you may have executed with Licensor regarding such Contributions.

6. Trademarks.

This License does not grant permission to use the trade names, trademarks, service marks, or product names of the Licensor, except as required for reasonable and customary use in describing the origin of the Work and reproducing the content of the NOTICE file.

7. Disclaimer of Warranty.

Unless required by applicable law or agreed to in writing, Licensor provides the Work (and each Contributor provides its Contributions) on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied, including, without limitation, any warranties or conditions of TITLE, NON-INFRINGEMENT, MERCHANTABILITY, or FITNESS FOR A PARTICULAR PURPOSE. You are solely responsible for determining the appropriateness of using or redistributing the Work and assume any risks associated with Your exercise of permissions under this License.

8. Limitation of Liability.

In no event and under no legal theory, whether in tort (including negligence), contract, or otherwise, unless required by applicable law (such as deliberate and grossly negligent acts) or agreed to in writing, shall any Contributor be liable to You for damages, including any direct, indirect, special, incidental, or consequential damages of any character arising as a result of this License or out of the use or inability to use the Work (including but not limited to damages for loss of goodwill, work stoppage, computer failure or malfunction, or any and all other commercial damages or losses), even if such Contributor has been advised of the possibility of such damages.

9. Accepting Warranty or Additional Liability.

While redistributing the Work or Derivative Works thereof, You may choose to offer, and charge a fee for, acceptance of support, warranty, indemnity, or other liability obligations and/or rights consistent with this License. However, in accepting such obligations, You may act only on Your own behalf and on Your sole responsibility, not on behalf of any other Contributor, and only if You agree to indemnify, defend, and hold each Contributor harmless for any liability incurred by, or claims asserted against, such Contributor by reason of your accepting any such warranty or additional liability. 
*/

using System;
using System.Data.Common;
using System.Collections.Generic;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;

namespace Chorizo
{
	public partial class Browser
	{

		static readonly object threadSafeLock = new object();
        //private static int defaultTimeout = 5000;

		private static IWebDriver driver;


        // Setup our drivers

        // Firefox driver 
        private static FirefoxProfile profile;
        private static FirefoxBinary binary;


        // Remote driver
        //
        private static DesiredCapabilities capabilities;

        // PhantomJS driver
        //private static PhantomJSOptions jsOptions;

		private Browser ()
		{
		}
			
		private static void StartBrowser()
		{
			// This needs to check for and kill off any firefox browsers running to keep things tidy.
            string browser = "firefox";
            switch (browser.ToLower())
            {
                case "firefox":

                    // Start up the firefox browser
                    profile = new FirefoxProfile ();
                    binary = new FirefoxBinary ("/Applications/Firefox.app/Contents/MacOS/firefox-bin");
                    driver = new FirefoxDriver (binary,profile);

                    break;


                case "chrome":

                    // Start up the firefox browser
                    driver = new ChromeDriver();

                    break;
                   
                case "grid":

                    // Start up a remote browser
                    capabilities = new DesiredCapabilities();
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);

                    break;



                case "phantomjs":

                    // setup for the mac .. note that you need to do the following ... 
                    // brew install phantomjs
                    // cd /usr/local/bin/
                    // sudo cp phantomjs PhantomJS.exe

                    //jsOptions = new PhantomJSOptions();
                    driver = new PhantomJSDriver("/usr/local/bin/");
                    break;

                default:
                    break;
            }
		}


		/// Private method that will return the DriverController -> singleton
		/// </summary>
		/// <returns>ControlHandler</returns>
		private static IWebDriver DriverController
		{
			get
			{
				// thread safe singleton code
				lock (threadSafeLock)
				{
					if (driver == null)
					{
						StartBrowser();
					}
					return driver;
				}
			}
		}

		public static void Close ()
		{
			DriverController.Close();
		}

		public static void NavigateTo(string url)
		{
			DriverController.Navigate ().GoToUrl (url);
		}
		
        private static IList<IWebElement> GetElements (string controlString)
        {
            DbConnectionStringBuilder _control = new DbConnectionStringBuilder();
            _control.ConnectionString = controlString;


            IList<IWebElement> _elements;
            if (_control.ContainsKey("class"))
            {
                _elements = DriverController.FindElements(By.ClassName(_control["class"].ToString()));
            }
            else if (_control.ContainsKey("css"))
            {
                _elements = DriverController.FindElements(By.CssSelector(_control["css"].ToString()));
            }
            else if (_control.ContainsKey("id"))
            {
                _elements = DriverController.FindElements(By.Id(_control["id"].ToString()));
            }
            else if (_control.ContainsKey("linktext"))
            {
                _elements = DriverController.FindElements(By.LinkText(_control["linktext"].ToString()));
            }
            else if (_control.ContainsKey("name"))
            {
                _elements = DriverController.FindElements(By.Name(_control["name"].ToString()));
            }
            else if (_control.ContainsKey("partiallinktext"))
            {
                _elements = DriverController.FindElements(By.PartialLinkText(_control["partiallinktext"].ToString()));
            }
            else if (_control.ContainsKey("tagname"))
            {
                _elements = DriverController.FindElements(By.TagName(_control["tagname"].ToString()));
            }
            else if (_control.ContainsKey("xpath"))
            {
                _elements = DriverController.FindElements(By.XPath(_control["xpath"].ToString()));
            }
            else
            {
                throw new NotImplementedException("The selection type has not been implemented in GetElements()");
            }

            return _elements;
        }

        private static IWebElement GetElement (string controlString)
        {
            DbConnectionStringBuilder _control = new DbConnectionStringBuilder();
            _control.ConnectionString = controlString;

            IWebElement _element;
            if (_control.ContainsKey("class"))
            {
                _element = DriverController.FindElement(By.ClassName(_control["class"].ToString()));
            }
            else if (_control.ContainsKey("css"))
            {
                _element = DriverController.FindElement(By.CssSelector(_control["css"].ToString()));
            }
            else if (_control.ContainsKey("id"))
            {
                _element = DriverController.FindElement(By.Id(_control["id"].ToString()));
            }
            else if (_control.ContainsKey("linktext"))
            {
                _element = DriverController.FindElement(By.LinkText(_control["linktext"].ToString()));
            }
            else if (_control.ContainsKey("name"))
            {
                _element = DriverController.FindElement(By.Name(_control["name"].ToString()));
            }
            else if (_control.ContainsKey("partiallinktext"))
            {
                _element = DriverController.FindElement(By.PartialLinkText(_control["partiallinktext"].ToString()));
            }
            else if (_control.ContainsKey("tagname"))
            {
                _element = DriverController.FindElement(By.TagName(_control["tagname"].ToString()));
            }
            else if (_control.ContainsKey("xpath"))
            {
                _element = DriverController.FindElement(By.XPath(_control["xpath"].ToString()));
            }
            else
            {
                throw new NotImplementedException("The selection type has not been implemented in GetElement()");
            }

            return _element;
        }

		public static string GetValue(string controlString)
		{
            DbConnectionStringBuilder _control = new DbConnectionStringBuilder();
            _control.ConnectionString = controlString;

            IWebElement _element = GetElement(controlString);

            string value;
            switch (_control["type"].ToString().ToLower())
            {
                case "input":
                case "text":
                case "typetext":
                    value = _element.GetAttribute("value");
                    break;

                
                default:

                    value = _element.Text;
                    break;
            }

            return value;
		}

        public static string GetSelectedValue(string controlString)
        {
            DbConnectionStringBuilder _control = new DbConnectionStringBuilder();
            _control.ConnectionString = controlString;

            IWebElement _element = GetElement(controlString);


            switch (_control["type"].ToString().ToLower())
            {
                case "radiobutton":
                    // Get all the elements of the radio group 
                    IList<IWebElement> _elements = GetElements(controlString);

                    // Loop through all the radio buttons, looking for a matching value
                    foreach (IWebElement option in _elements)
                    {
                        if (option.Selected)
                        {
                            // Click on the matching option
                            return option.GetAttribute("value");
                           
                        }
                    }

                    return _element.Selected.ToString();

                case "select":
                    SelectElement _selectedElement = new SelectElement(_element);
                    return _selectedElement.SelectedOption.Text;

                default:
                    return _element.Text;

            }


        }

        public static void Invoke(string controlString)
        {
            DbConnectionStringBuilder _control = new DbConnectionStringBuilder();
            _control.ConnectionString = controlString;

            if (! _control.ContainsKey("type"))
            {
                throw new ArgumentOutOfRangeException("type","The control type has not been implemented in SetValue() for '{0}'", controlString);
            }

            IWebElement _element = GetElement(controlString);

            switch (_control["type"].ToString().ToLower())
            {
                case "button":
                case "submit":
                    _element.Click();
                    break;

                default:
                    _element.Click();
                    break;

            }

        }

        public static void SetValue(string controlString, string value)
		{
            DbConnectionStringBuilder _control = new DbConnectionStringBuilder();
            _control.ConnectionString = controlString;

            if (! _control.ContainsKey("type"))
            {
                throw new ArgumentOutOfRangeException("type","The control type has not been implemented in SetValue() for '{0}'", controlString);
            }
                   
            IWebElement _element = GetElement(controlString);

           
            switch (_control["type"].ToString().ToLower())
            {
                case "input":
                case "text":
                    _element.Clear();
                    _element.SendKeys(value ?? string.Empty);
          

                    //IWebDriver driver; // assume assigned elsewhere
                    //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                    //string title = (string)js.ExecuteScript("arguments[0].value ='';", _element);

                    //((IJavascriptExecutor)driver).ExecuteScript("arguments[0].value ='';", element);
                    WaitForAsyncPostBackToComplete();
                    break;

                case "typetext":
                    _element.Clear();
                    _element.SendKeys(value ?? string.Empty);
                    WaitForAsyncPostBackToComplete();
                    break;

                case "select":
                    // if the value to set is empty, ignore it.
                    if (!string.IsNullOrEmpty(value))
                    {
                        WaitForAsyncPostBackToComplete();
                        SelectElement selectElement = new SelectElement(_element);
                        selectElement.SelectByText(value); 

                        WaitForAsyncPostBackToComplete();
                    }
                    break;

                case "checkbox":
                    // if the value to set is empty, ignore it.
                    if (!string.IsNullOrEmpty(value))
                    {
                        bool isChecked;
                        bool.TryParse(value, out isChecked);

                        WaitForAsyncPostBackToComplete();
                    }
                    break;

                case "radiobutton":
                    // if the value to set is empty, ignore it.
                    if (!string.IsNullOrEmpty(value))
                    {
                        bool isChecked;
                        bool.TryParse(value, out isChecked);

                        // Get all the elements of the radio group 
                        IList<IWebElement> _elements = GetElements(controlString);

                        // Loop through all the radio buttons, looking for a matching value
                        foreach (IWebElement option in _elements)
                        {
                            if (option.GetAttribute("value") == value)
                            {
                                // Click on the matching option
                                option.Click();
                                break;
                            }
                        }

                        WaitForAsyncPostBackToComplete(); ;
                    }
                    break;

                case "fileupload":
                    //  _document.FileUpload(_control.WatinAttribute).Set(value);
                    WaitForAsyncPostBackToComplete();
                    break;

                default:
                    throw new NotImplementedException("The control type has not been implemented in SetValue()");
            }
		}

        private static void WaitForAsyncPostBackToComplete()
        {

        }

	}
}

