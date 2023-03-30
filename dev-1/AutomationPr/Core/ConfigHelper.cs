using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;

namespace AutomationPr
{
    public class ConfigHelper
    {
        public void PrintConfigInformation(Config config)
        {
            foreach(var conf in config.configs)
            {
                Console.WriteLine(conf.ToString());
            }
        }

        public void PrintIncorrectConfigInformation(Config config)
        {
            Console.WriteLine($"\nNames of browsers for which the configuration is NOT correct:");

            foreach (var browser in CheckConfigTestsForBrowsers(config))
            {
                Console.WriteLine(browser);
            }
        }

        private List<string> CheckConfigTestsForBrowsers(Config config)
        {
            var browsersName = new List<string>();
            
            foreach(var conf in config.configs)
            {
                foreach(var user in conf.Users)
                {
                    if (user.UserRole == "admin" && user.TestNameList.Count <= 1 || string.IsNullOrEmpty(user.Login) || string.IsNullOrEmpty(user.Password))
                    {
                        browsersName.Add(conf.BrowserName);
                        break;
                    }
                    else if (!user.UserRole.Equals("admin") && !string.IsNullOrEmpty(user.UserRole) && user.TestNameList.Count < 2)
                    {
                        browsersName.Add(conf.BrowserName);
                        break;
                    }

                    break;
                }
            }

            return browsersName;
        }
    }
}
