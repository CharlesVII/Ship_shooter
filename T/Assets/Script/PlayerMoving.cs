using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public float SpeedMoving;

    public Vector3 PointMoving;

    private void Update()
    {
        PlayerMove();
    }

    protected void PlayerMove()
    {
        PointMoving = InputSystem.instance.TakeMousePos();
        transform.parent.position = Vector3.MoveTowards(transform.position, PointMoving, SpeedMoving * Time.deltaTime) ;
    }
}
