namespace SisGUAPA.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        //Exemplos de teste sem mock:
        //https://www.c-sharpcorner.com/article/crud-operations-unit-testing-in-asp-net-core-web-api-with-xunit/

        //Exemplos de teste com mock?
        //    https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/contact-manager/iteration-5-create-unit-tests-cs
        /*
         * n practice, when writing unit tests, you concentrate on writing tests for your 
         * business logic (for example, validation logic). In particular, you do not write 
         * unit tests for your data access logic or your view logic.
         *
        you typically do not write unit tests for code that interacts with a database.
        Running hundreds of unit tests against a live database would be too slow. 
        Instead, you mock your database and write code that interacts with the mock database (we discuss mocking a database below).x
         *
         For a similar reason, you typically do not write unit tests for views. In order to test a view, you must spin up a web server. Because spinning up a web server is a relatively slow process, creating unit tests for your views is not recommended.

If your view contains complicated logic then you should consider moving the logic into Helper methods. 
        You can write unit tests for Helper methods that execute without spinning up a web server.*/


    }
}