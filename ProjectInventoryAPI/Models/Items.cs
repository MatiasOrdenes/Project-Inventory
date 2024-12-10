namespace ProjectInventoryAPI.Models
{
    public class Item
    {
        public int Id { get; set; } // Unique identifier for the item
        public string Name { get; set; } // Name of the item
        public int Quantity { get; set; } // Quantity of the item in inventory
        public string Description { get; set; } // Additional details about the item
    }
}