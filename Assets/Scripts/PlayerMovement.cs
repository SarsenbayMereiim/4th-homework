using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMovement
{
    public Rigidbody Rigidbody { get; private set; }
    public float Speed { get; private set; }

    public void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Speed = 9f;
    }

    public void Movement()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        transform.Translate(direction * Speed * Time.deltaTime);
    }
}