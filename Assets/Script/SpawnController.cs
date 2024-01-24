using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] float spawnInterval = 3f; //敵出現間隔

    EnemySpawner[] spawners; //EnemySpawnerのリスト
    float timer = 0f; //出現時間判定用のタイマー

    // Start is called before the first frame update
    void Start()
    {
        //子オブジェクトに存在するEnemySpawnerのリスト取得
        spawners = GetComponentsInChildren<EnemySpawner>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        //出現の判定
        if(spawnInterval < timer)
        {
            //ランダムにEnemySpawnerを選択して敵を出現させる
            var index = Random.Range(0, spawners.Length);
            spawners[index].Spawn();

            timer = 0f;
        }
    }
}
