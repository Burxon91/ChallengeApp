namespace ChallengeApp.Tests
{
    public class MarkTests
    {
       
        [Test]
        public void AddMarkVerification()
        {
            //arrange 
            var Employee = new Employee("Adam");
            Employee.AddMark(5);
            Employee.AddMark(6);
            Employee.RemoveMark(5);
            Employee.AddBonus(7);

            //act
            var result = Employee.Result;

            //assert
            Assert.AreEqual(20, result);
        }
        
       
       
    }
}