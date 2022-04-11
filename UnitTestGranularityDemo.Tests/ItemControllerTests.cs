using Moq;
using Xunit;

namespace UnitTestGranularityDemo.Tests
{
    public class ItemControllerTests
    {
        private ItemController CreateSut()
        {
            var itemServiceMock = new Mock<IItemService>(MockBehavior.Strict);
            itemServiceMock.Setup(e => e.Serialize(It.IsAny<Item>())).Returns("serialized");
            return new ItemController(itemServiceMock.Object);
        }

        [Fact]
        public void ProcessWrapsSerializedOutput()
        {
            //arrange
            var sut = CreateSut();

            //act
            var res = sut.Process(new Item { });

            //assert
            Assert.Equal("Output is: serialized", res);
        } 
    }
}
