using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ValorPuntuacion = 0;
    Text Puntuacion;
    public GameObject Retry;
    public GameObject Winner;

    void Start()
    {
        Puntuacion = GetComponent<Text>();
        InvokeRepeating(nameof(RestaTimer), 10, 10);
    }

    void Update()
    {
        Puntuacion.text = "Puntuacion: " + ValorPuntuacion;

        if (ValorPuntuacion < 0)
        {
            Time.timeScale = 0;
            Puntuacion.text = "Puntuacion: 0";
            Retry.SetActive(true);
        }

        if (ValorPuntuacion >= 500)
        {
            Time.timeScale = 0;
            Puntuacion.text = "Nivel superado!";
            Winner.SetActive(true);
        }

    }

    void RestaTimer()
    {
        ValorPuntuacion -= 5;
    }
}
