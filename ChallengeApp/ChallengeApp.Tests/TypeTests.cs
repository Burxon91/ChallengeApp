using NUnit.Framework.Interfaces;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TwoIntValueShouldBeTheSame() //typwartościowy
        {
            //arrange 
            int n1 = 124;
            int n2 = 124;
            //act

            //assert
            Assert.AreEqual(n1, n2);
        }
        
        [Test]
        public void TwoFloatValueShouldBeTheSamet() //typ wartościowy
        {
            //arrange 
            float f1 = 0.25f;
            float f2 = 0.25f;
            //act

            //assert
            Assert.AreEqual(f1, f2);
            
        }
        [Test]
        public void TwoEmployeeShouldBeTheSame() //typ referencyjny 
        {
            //arrange 
            var user1 = GetEmployee("Adam");
            var user2 = GetEmployee("Adam");
            //act

            //assert
            Assert.AreEqual(user1.Name, user2.Name);

        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
