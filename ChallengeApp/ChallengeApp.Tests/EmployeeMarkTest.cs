namespace ChallengeApp.Tests
{
    public class Tests
    {
    
        [Test]
        public void AvgVerification()
        {
            //arrange 
            var Employee = new Employee("Stefan", "Batory");
            Employee.AddGrade(5);
            Employee.AddGrade(6);
           

            //act
            var result = Employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(5.5, 2), Math.Round(result.Avg, 2));
            
        }
        [Test]
        public void MinVerification()
        {
            //arrange 
            var Employee = new Employee("Stefan", "Batory");
            Employee.AddGrade(5);
            Employee.AddGrade(6);


            //act
            var result = Employee.GetStatistics();

            //assert
             Assert.AreEqual(5f, result.Min);
        
        }
        [Test]
        public void MaxVerification()
        {
            //arrange 
            var Employee = new Employee("Stefan", "Batory");
            Employee.AddGrade(5);
            Employee.AddGrade(6);


            //act
            var result = Employee.GetStatistics();

            //assert
            Assert.AreEqual(6f, result.Max);
        }
    }
}