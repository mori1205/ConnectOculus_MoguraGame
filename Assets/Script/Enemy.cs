// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Enemy : MonoBehaviour
// {
//     [SerializeField] int point = 5;
//     Score score;

//     private void Start()
//     {
//         var gameObj = GameObject.FindWithTag("Score");
//         score = gameObj.GetComponent<Score>();
//     }
    

//     // Start is called before the first frame update
//     void OnHitHammer()
//     {
        
//         GoDown();
//     }

//     void GoDown()
//     {
//         score.AddScore(point);
//         Destroy(gameObject);
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int point = 5;
    [SerializeField] float lifespan = 5f; // 敵の生存時間（秒）
    Score score;
    // private AudioSource sound01;

    private void Start()
    {
        var gameObj = GameObject.FindWithTag("Score");
        score = gameObj.GetComponent<Score>();

        // 一定時間後に敵を破壊するコルーチンを開始
        StartCoroutine(DestroyAfterLifespan());
    }

    // ハンマーが敵にヒットした場合に呼び出されるメソッド
    public void OnHitHammer()
    {
        if (score != null)
        {
            GoDown();
        }
    }

    void GoDown()
    {
        score.AddScore(point);
        Destroy(gameObject);
    }

    // 敵を一定時間後に破壊するコルーチン
    private IEnumerator DestroyAfterLifespan()
    {
        yield return new WaitForSeconds(lifespan);
        Destroy(gameObject); // 敵を破壊する
    }
}

