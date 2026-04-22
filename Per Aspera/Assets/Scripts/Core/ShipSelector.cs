using System.Linq;

public class ShipSelector
{
    private ShipData _currentShip;
    private readonly ShipCatalog _catalog;

    public ShipSelector(ShipCatalog catalog)
    {
        _catalog = catalog;
        _currentShip = _catalog.DefaultShip;
    }

    public ShipData CurrentShip => _currentShip;

    public void SelectShip(int id)
    {
        var selected = _catalog.GetShipById(id);
        if (selected != null)
            _currentShip = selected;
    }

    public void SelectShip(ShipData ship)
    {
        if (_catalog.AllShips.Contains(ship))
            _currentShip = ship;
    }
}
