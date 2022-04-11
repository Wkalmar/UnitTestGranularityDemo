namespace UnitTestGranularityDemo
{
    public class ItemController
    {
        private readonly IItemService _service;

        public ItemController(IItemService service)
        {
            _service = service;
        }

        public string Process(Item item)
        {
            var serialized = _service.Serialize(item);
            return _service.Wrap(serialized);
        }
    }
}
