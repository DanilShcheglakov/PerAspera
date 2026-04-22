using UnityEngine;
using UnityEngine.UI;
using VContainer;

public class RaceCoordinator : MonoBehaviour
{
    [SerializeField]private Button _startButton;
   [SerializeField] private Ship _ship;

    private ShipSelector _shipSelector;

    [Inject]
    public void Construct(ShipSelector shipSelector)
    {
        _shipSelector = shipSelector;
        _startButton.onClick.AddListener(StartRace);
    }

    private void StartRace()
    {
        ShipData currentShip = _shipSelector.CurrentShip;
        _ship.Initialize(currentShip);
    }
}
