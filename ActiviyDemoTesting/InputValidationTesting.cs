using ActivityLibrary;
using Xunit;

namespace ActiviyDemoTesting
{
    public class InputValidationTesting
    {
        [Fact]
        public void TestInputForRange()
        {
            var listCount = 17;
            var userInput = "14";
            Assert.True(InputValidation.IsInputValid(userInput, listCount));
        }

        [Fact]
        public void TestInputForNull()
        {
            var listCount = 17;
            Assert.False(InputValidation.IsInputValid(null, listCount));
        }

        [Fact]
        public void TestInputForParsable()
        {
            var listCount = 17;
            var userInput = "blub";
            Assert.False(InputValidation.IsInputValid(userInput, listCount));
        }
    }
}
