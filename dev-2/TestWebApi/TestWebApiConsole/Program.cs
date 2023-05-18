using System.Collections.Generic;
using WebApiFramework;
using WebApiFramework.ApiEntites;

namespace TestWebApiConsole
{
    class Program
    {
        private static void Main()
        {
            var browsers = new List<Browser>()
            {
                new Browser() { ID = 3, Name = "Opera", Version = "1.1.1", Users =
                {
                    new User() { UserName = "UseVl", Password = "1234" },
                    new User() { UserName = "UseVova", Password = "123465667656" }
                } }
            };

            WebApiHelper webApiHelper = new();

            var getResponce = webApiHelper.GetTypedRequest();

            var postResponce = webApiHelper.PostRequest(browsers);

            var putResponce = webApiHelper.PutRequest(new Browser()
            {
                ID = 3,
                Name = "Opera",
                Version = "1.1.1",
                Users =
                {
                    new User() { UserName = "Vlad", Password = "0" },
                    new User() { UserName = "Vova", Password = "123465667656" }
                }
            });

            var deleteResponce = webApiHelper.DeleteRequest(3);
        }
    }
}
