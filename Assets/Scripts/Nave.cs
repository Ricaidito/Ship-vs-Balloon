using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float CD = 0.5f;
    public float NB = 0.5f;
    public GameObject bullet;
    public GameObject gameOver;
    private Rigidbody2D rb;

    void Update()
    {
        if (Time.time > NB)
        {

            if (Input.GetKeyDown("f"))
            {
                Instantiate(bullet, transform.position, Quaternion.identity);
                SoundManager.PlaySound("missile_shoot");
                NB = Time.time + CD;
            }
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector2(0, 3.5f);
        }

        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector2(0, -3.5f);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void MovArriba()
    {
        rb.velocity = new Vector2(0, 3.5f);   
    }

    public void MovAbajo()
    {
        rb.velocity = new Vector2(0, -3.5f);
    }

    public void Atacar()
    {

        if (Time.time > NB)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            SoundManager.PlaySound("missile_shoot");
            NB = Time.time + CD;
        }
        
    }
}
