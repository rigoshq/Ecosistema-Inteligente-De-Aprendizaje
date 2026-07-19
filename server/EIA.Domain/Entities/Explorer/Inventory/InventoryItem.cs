namespace EIA.Domain.Entities.Explorer.Inventory;

public class InventoryItem
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Code { get; set; } = "";

    public string Name { get; set; } = "";

    public string Description { get; set; } = "";

    public int Quantity { get; set; }

    public bool Consumable { get; set; }
}