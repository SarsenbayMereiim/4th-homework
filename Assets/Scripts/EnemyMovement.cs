using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour, IMovement
{
    public Rigidbody Rigidbody { get; private set; }
    public GameObject Player { get; private set; }
    public float Speed { get; private set; }

    public void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
        Speed = 10f;
    }

    public void Movement()
    {
        Vector3 playerDirection = (Player.transform.position - transform.position).normalized;
        Rigidbody.AddForce(playerDirection * Speed);
    }
}
