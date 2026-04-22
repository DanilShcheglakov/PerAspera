using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShipCatalog", menuName = "SpaceShip/ShipCatalog")]
public class ShipCatalog : ScriptableObject
{
     private const int DefaultShipIndex = 0; 
    
    [SerializeField] private List<ShipData> _allShips;

    public IReadOnlyList<ShipData> AllShips => _allShips;
    public ShipData DefaultShip => _allShips.Count > DefaultShipIndex ? _allShips[DefaultShipIndex] : null;

    public ShipData GetShipById(int id = DefaultShipIndex)
    {
        if (id >= 0 && id < _allShips.Count)
            return _allShips[id];
        return DefaultShip;
    }
}
