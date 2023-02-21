using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITimer : MonoBehaviour
{
    float time = 0f;
    float startingTime = 300f;
    
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI worldText;

    private void Start()
    {
        time = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        //worldText.text = worldText.ToString();
        
        time -= 1 * Time.deltaTime;
        timerText.text = $"Time \n{time.ToString("0")}";
        if (time <= 0)
        {
            time = 0;
        }
    }
}
