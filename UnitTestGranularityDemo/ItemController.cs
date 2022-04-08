namespace UnitTestGranularityDemo
{
    public class ItemController
    {
        private readonly ItemService _serializer;

        public ItemController(ItemService serializer)
        {
            _serializer = serializer;
        }

        public string Process(Item item)
        {
            return $"Output is: {_serializer.Serialize(item)}";
        }
    }
}
