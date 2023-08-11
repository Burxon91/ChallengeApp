namespace ChallengeApp.Tests
{
    public class Tests
    {
    
        [Test]
        public void GradesVerification()
        {
            //arrange 
            var Employee = new Employee("Stefan", "Batory");
            Employee.AddGrade(5);
            Employee.AddGrade(6);
           

            //act
            var result = Employee.GetStatistics();

            //assert
            Assert.AreEqual(5.5f, result.Avg);
            Assert.AreEqual(5f, result.Min);
            Assert.AreEqual(6f, result.Max);
        }
    }
}