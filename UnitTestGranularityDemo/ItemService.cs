using System;

namespace UnitTestGranularityDemo
{
    public interface IItemService
    {
        string Serialize(Item input);
    }

    public class ItemService : IItemService
    {
        public string Serialize(Item input)
        {
            switch (input.Type)
            {
                case ItemType.String:
                    return input.Value;
                case ItemType.Geo:
                    return SeriazlieGeo(input.Value);
                case ItemType.Range:
                    return SerializeRange(input.Value);
                default:
                    throw new ArgumentOutOfRangeException(nameof(input.Type));
            }
        }

        private string SerializeRange(string value)
        {
            var items = value.Split(new[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (items.Length != 2)
            {
                throw new ArgumentException(nameof(value));
            }
            return $"gte:{items[0]},lte:{items[1]}";
        }

        private string SeriazlieGeo(string value)
        {
            var items = value.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (items.Length != 2)
            {
                throw new ArgumentException(nameof(value));
            }
            return $"lat:{items[0]},lon:{items[1]}";
        }
    }
}
