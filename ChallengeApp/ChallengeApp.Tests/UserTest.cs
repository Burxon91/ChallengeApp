namespace ChallengeApp.Tests
{
    public class Tests
    {
       
        [Test]
        public void WhenUserCollectTwoSetOfPoint_ShouldReturnCorrectSumAsResult()
        {
            //arrange
            var user = new User("Adam", "111123as");
            user.AddScore(5);
            user.AddScore(6);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(11, result);
        }
    }
}