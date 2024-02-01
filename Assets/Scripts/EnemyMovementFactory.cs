using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementFactory : MonoBehaviour, IMovementFactory
{
    public IMovement CreateMovement()
    {
        GameObject enemy = new GameObject("Enemy");
        enemy.transform.position = new Vector3(0, 1, 0);
        return enemy.AddComponent<EnemyMovement>();
    }
}
