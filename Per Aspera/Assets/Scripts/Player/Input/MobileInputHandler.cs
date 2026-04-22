using UnityEngine;

public class MobileInputHandler :  IInputHandler
{
    public float GetHorizontalAxis()
    {
        float direction = 0f;

        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);

                if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
                {
                    if (touch.position.x < Screen.width / 2f)
                    {
                        direction = -1f;
                    }
                    else 
                    {
                        direction = 1f;
                    }
                }
            }
        }

        return direction;
    }
}

