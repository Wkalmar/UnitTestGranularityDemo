namespace UnitTestGranularityDemo
{
    public class ItemController
    {
        private readonly IItemService _serializer;

        public ItemController(IItemService service)
        {
            _serializer = service;
        }

        public string Process(Item item)
        {
            var serializedOutput = _serializer.Serialize(item);
            return _serializer.Wrap(serializedOutput);
        }
    }
}
