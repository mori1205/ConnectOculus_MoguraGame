using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class RemainTimer : MonoBehaviour
{
    [SerializeField] float gameTime = 60.0f;
    
    Text uiText;

    float currentTime;
    
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
        currentTime = gameTime;
    }

    // Update is called once per frameL
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0.0f)
        {
            currentTime = 0.0f;
        }
        uiText.text = string.Format("残り時間 : {0:F} 秒", currentTime);
    }

    public bool IsCountingdDown()
    {
        return currentTime > 0.0f;
    }
}
