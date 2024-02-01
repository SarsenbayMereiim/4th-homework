using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Player : Entity
    {
        protected override IMovementFactory MovementFactory => new PlayerMovementFactory();
    }

   
