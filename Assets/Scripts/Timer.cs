using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool timer_on;
    Text clock;
    static private float timer;

    private void Start()
    {
        clock = GetComponent<Text>();
        clock.text = "Tiempo: " + timer.ToString("F0");
        ResetTimer();
    }

    void Update()
    {
        timer += Time.deltaTime;
        clock.text = "Tiempo: " + timer.ToString("F0");
    }

    public void ResetTimer()
    {
        timer = 0;
    }
}
