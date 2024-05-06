using zConsole.Codility_exercises.String;

namespace zConsole.Tests
{
    [TestClass]
    public class TestsForStringTasks
    {
        [TestMethod]
        public void CheckIntToRoman()
        {
            string result = IntToRoman.ToRoman(8);
            Assert.IsNotNull(result);
        }
    }
}