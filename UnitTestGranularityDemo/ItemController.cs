namespace UnitTestGranularityDemo
{
    public class ItemController
    {
        private readonly IItemService _serializer;

        public ItemController(IItemService serializer)
        {
            _serializer = serializer;
        }

        public string Process(Item item)
        {
            return $"Output is: {_serializer.Serialize(item)}";
        }
    }
}
