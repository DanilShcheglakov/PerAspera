using UnityEngine;

public class Ship : MonoBehaviour
{
    private ShipData _shipData;
    private Mover _mover;

    private void Start()
    {
        _mover = GetComponent<Mover>();
    }

    public void Initialize(ShipData shipData)
    {
        _shipData = shipData; 
        _mover.Initialize(shipData);

        Instantiate(shipData.ShipPrefab, _mover.transform).transform.SetParent(transform);
    }
}
