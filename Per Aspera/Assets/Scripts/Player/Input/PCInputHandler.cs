using UnityEngine;

public class PCInputHandler : IInputHandler
{
    private const string Horizontal = "Horizontal";

    public float GetHorizontalAxis()
    {
        return Input.GetAxisRaw(Horizontal);
    }
}
