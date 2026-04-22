using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newSpaceShip", menuName = "SpaceShip/ShipData")]
public class ShipData : ScriptableObject
{
    [Header("Основные параметры")]
    [SerializeField] private string shipName;
    [SerializeField] private GameObject shipPrefab;

    [Header("Параметры движения")]
    [SerializeField] private float _maxRotationAngle;
    [SerializeField] private float _maxHorizontalSpeed;
    [SerializeField] private float _timeOfChangeHorizontalSpeed;


    public string ShipName => shipName;
    public GameObject ShipPrefab => shipPrefab;
    public float MaxRotationAngle => _maxRotationAngle;
    public float MaxHorizontalSpeed => _maxHorizontalSpeed;
    public float TimeOfChangeHorizontalSpeed => _timeOfChangeHorizontalSpeed;
}
