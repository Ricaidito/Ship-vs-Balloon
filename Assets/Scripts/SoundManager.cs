using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip FireSound, DestroySound;
    static AudioSource audioSrc;

    void Start()
    {
        FireSound = Resources.Load<AudioClip>("missile_shoot");
        DestroySound = Resources.Load<AudioClip>("meteor_explode");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string sfx) 
    {
        switch (sfx)
        {
            case "missile_shoot":
                audioSrc.PlayOneShot(FireSound);
                break;
            case "meteor_explode":
                audioSrc.PlayOneShot(DestroySound);
                break;
        }
    }
}
