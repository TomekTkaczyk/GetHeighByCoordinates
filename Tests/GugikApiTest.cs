using GetHeightByCoordinates;
using Xunit;

namespace Tests
{
    public class GugikApiTest
    {
        [Fact]
        public void Returns_response()
        {
            var height = Commands.GetHeight(486617, 637928);

            Assert.Equal("110.5", height);
        }
    }
}
