using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {

        public static bool AppSettingsKeyValueMissing(string[] keysList)
        {
            bool keyValueMissing = false;
            try
            {
                foreach (string key in keysList)
                {
                    if (ConfigurationManager.AppSettings[key] != null)
                    {
                        if (string.IsNullOrWhiteSpace(Convert.ToString(ConfigurationManager.AppSettings[key])))
                        {
                            keyValueMissing = true;
                            Console.Write("AppSettings : Value missing for the key - " + key);
                            break;
                        }
                    }
                    else
                    {
                        keyValueMissing = true;
                        Console.Write("AppSettings : Mandatory key missing - " + key);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return keyValueMissing;
        }


        static void Main(string[] args)
        {

            //  bool res=   AppSettingsKeyValueMissing(new string[] {"name","age" });

            // Recursion.Pirnt();


            // LargeNumber.BiggerOne(new int[] {2,5,3,7,9 });

            // Operator.MixIncrement();


            Run3.Execute();
           

            Console.Read();
        }
    }
}
