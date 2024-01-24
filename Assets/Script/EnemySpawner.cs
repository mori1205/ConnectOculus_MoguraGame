using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy enemyPrefab;
    Enemy enemy;

   public void Spawn()
    {
        //出現中でなければ敵を出現
        if (enemy == null)
        {
            enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
        }
    }
    
}
