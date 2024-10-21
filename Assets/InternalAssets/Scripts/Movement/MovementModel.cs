using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementModel
{
    public float CurrentSpeed{ get; set;}

    public MovementModel(float initialSpeed)
    {
        CurrentSpeed = initialSpeed;
    }
}
