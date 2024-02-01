using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement
{
    Rigidbody Rigidbody { get; }
    float Speed { get; }
    void Movement();

}
