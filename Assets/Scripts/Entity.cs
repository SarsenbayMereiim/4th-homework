using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected IMovement Movement { get; private set; }

    protected abstract IMovementFactory MovementFactory { get; }

    public virtual void Start()
    {
        Movement = MovementFactory.CreateMovement();
    }

    public virtual void Update()
    {
        Movement.Movement();
    }
  }
