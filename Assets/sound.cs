using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource audio;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "food")
        {
            audio.Play();
        }
    }
}
