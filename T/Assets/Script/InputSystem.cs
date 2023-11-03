using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : Singleton<InputSystem>
{
    public Vector3 directionMoving;


    public Vector3 TakeMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
