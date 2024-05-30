using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSounds : MonoBehaviour
{
    public AudioSource Hitsound;

    public void OnCollisonEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Hitsound.Play();
        }

    }
}
