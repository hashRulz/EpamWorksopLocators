using EpamWorksopLocators.PageObjects;

namespace EpamWorksopLocators
{
    public class Tests : BaseTest
    {
      
        [Test]
        public void Test1()
        {
            var loginPage = new EmailPage();
            loginPage.Open();
            loginPage.Login("epamtaskdemo@gmail.com", "EpamTask123");
            //Assert.Pass();
            //loginPage.SaveMail("epamtaskdemo@gmail.com", "Sample Subject");
           
            loginPage.SaveMail("epamtaskdemo@gmail.com", "sample subject");
            Assert.Pass();

        }

        //[Test]
        //public void Test2()
        //{
        //    var loginPage = new EmailPage();
        //    loginPage.Open();
        //    loginPage.SaveMail("epamtaskdemo@gmail.com", "sample subject");
        //    Assert.Pass();
        //}
    }
}