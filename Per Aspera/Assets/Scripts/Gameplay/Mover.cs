using UnityEngine;
using VContainer;

public class Mover : MonoBehaviour
{
    private float _startSpeed = 10f;
    private float _currentSpeed;
    private float _timeOfChangeHorizontalSpeed;

    private float _curentHorizontalSpeed;
    private float _maxHorizontalSpeed = 10f;

    private float _currentRotationAngle;
    private float _maxRotationAngle = 45f;


    private float _smoothVelocity;
    private float _rotationVelocity;


    private IInputHandler _inputHandler;

    [Inject]
    private void Construct(IInputHandler inputHandler)
    {
        _inputHandler = inputHandler;
        _currentSpeed = _startSpeed;
    }

    public void Initialize(ShipData shipData)
    {
        _maxRotationAngle = shipData.MaxRotationAngle;
        _maxHorizontalSpeed = shipData.MaxHorizontalSpeed;
        _timeOfChangeHorizontalSpeed = shipData.TimeOfChangeHorizontalSpeed;
    }

    private void Update()
    {
        MoveForward();
        Turn();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _currentSpeed * Time.deltaTime);
    }

    private void Turn()
    {
        float targetHorizontalSpeed = _inputHandler.GetHorizontalAxis() * _maxHorizontalSpeed;
        float targetRotationAngle = -_inputHandler.GetHorizontalAxis() * _maxRotationAngle;

        _curentHorizontalSpeed = Mathf.SmoothDamp(
            _curentHorizontalSpeed,
            targetHorizontalSpeed,
            ref _smoothVelocity,
            _timeOfChangeHorizontalSpeed);

        _currentRotationAngle = Mathf.SmoothDampAngle(
             _currentRotationAngle,
             targetRotationAngle,
            ref _rotationVelocity,
            _timeOfChangeHorizontalSpeed);

        transform.Translate(Vector3.right * _curentHorizontalSpeed * Time.deltaTime);
        transform.localRotation = Quaternion.Euler(Vector3.forward * _currentRotationAngle);
    }
}
