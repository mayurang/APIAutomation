using System;
using APIAutomation.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APIAutomation.TestMethod
{
    [TestClass]
    public class RESTAPIValidation
    {
        [TestMethod]
        public void TestMethod1()
        {
            RESTUtility restUtility = new RESTUtility();
            string result=restUtility.GetAPIGetMethodResponse("http://services.groupkt.com/state/get/USA/all");
            //Console.WriteLine(result);
            //Console.WriteLine(restUtility.CountryStatesResult(result).RestResponse.result[0].abbr);

            for(int i=0; i < restUtility.CountryStatesResult(result).RestResponse.result.Length; i++)
            {
                Console.WriteLine(restUtility.CountryStatesResult(result).RestResponse.result[i].abbr);
                Console.WriteLine(restUtility.CountryStatesResult(result).RestResponse.result[i].largest_city);
            }

        }
    }
}
