using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject enemyPrefab;

    public IMovement CreateMovement()
    {
        GameObject enemy = Instantiate(enemyPrefab);
        enemy.AddComponent<EnemyMovement>();
        return enemy.GetComponent<IMovement>();
    }
}


