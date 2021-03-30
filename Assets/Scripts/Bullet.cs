using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float Speed = 4f;

    void Update()
    {
        transform.Translate(new Vector2(-3, 0f) * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Meteorito1")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Meteorito2")
        {
            Destroy(this.gameObject);
        }
    }

}
