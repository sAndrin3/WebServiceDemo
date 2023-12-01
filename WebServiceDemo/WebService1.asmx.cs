using System.Collections.Generic;
using System.Web.Services;

namespace WebServiceDemo
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(MessageName="Add2Numbers")]
        public int Add(int firstNumber, int secondNumber)
        {

            return firstNumber + secondNumber;
        }

        [WebMethod]
        public int Add(int firstNumber, int secondNumber, int thirdNumber)
        {

            return firstNumber + secondNumber + thirdNumber;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATIONS"] == null){
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any calculations");
                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATIONS"];
            }
        }
    }
}
