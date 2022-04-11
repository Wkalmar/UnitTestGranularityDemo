using System.Collections.Generic;
using Xunit;

namespace UnitTestGranularityDemo.Tests
{
    public class ItemsServiceTests
    {
        private ItemService CreateSut()
        {
            return new ItemService();
        }

        public static IEnumerable<object[]> SerializeTestData => new List<object[]>
        {
            new object [] { new Item
            {
                Type = ItemType.String,
                Value = "test value"
            }, "test value" },
            new object [] { new Item
            {
                Type = ItemType.Geo,
                Value = "45,54"
            }, "lat:45,lon:54" },
            new object [] { new Item
            {
                Type = ItemType.Range,
                Value = "45-54"
            }, "gte:45,lte:54" },
            
        };

        [Theory]
        [MemberData(nameof(SerializeTestData))]
        public void Serialize(Item item, string expectedResult)
        {
            //arrange
            var sut = CreateSut();

            //act
            var actualResult = sut.Serialize(item);

            //assert
            Assert.Equal(actualResult, expectedResult);
        }
    }
}
