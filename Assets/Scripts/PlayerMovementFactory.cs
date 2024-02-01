using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementFactory : MonoBehaviour, IMovementFactory
{
    public GameObject playerPrefab;

    public IMovement CreateMovement()
    {
        GameObject player = Instantiate(playerPrefab);
        player.AddComponent<PlayerMovement>();
        return player.GetComponent<IMovement>();
    }
}

