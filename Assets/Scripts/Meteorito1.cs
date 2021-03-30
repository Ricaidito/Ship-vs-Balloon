using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorito1 : MonoBehaviour
{

    private float Speed = 2f;

    void Start()
    {
        transform.position = new Vector2(Random.Range(-9.95f, 6.1f), -6.3f);
    }

    void Update()
    {
        transform.Translate(new Vector2(0, 2f) * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Bullet")
        {
            SoundManager.PlaySound("meteor_explode");
            Score.ValorPuntuacion++;
            Destroy(this.gameObject);
        }
    }
}
