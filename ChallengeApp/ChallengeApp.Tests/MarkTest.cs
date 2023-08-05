namespace ChallengeApp.Tests
{
    public class Tests
    {
       
        [Test]
        public void AddMarkVerification()
        {
            //arrange
            var Employee = new Employee("Adam", "Nowak", 24);
            Employee.AddMark(5);
            Employee.AddMark(6);
            Employee.AddBonus(7); //podwojenie oceny
            Employee.RemoveMark(5); //minus podana ocena

            //act
            var result = Employee.Result;

            //assert
            Assert.AreEqual(20, result);
        }
        
       
       
    }
}