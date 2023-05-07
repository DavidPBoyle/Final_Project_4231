using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eat : MonoBehaviour
{

    public AudioSource winner;
    public GameObject hamburger;
    public Transform spawnPoint;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "food")
        {
            ScoreManager.scoreUp++;
            Destroy(collision.gameObject);
         
        }

        if (collision.gameObject.tag == "enemy")
        {
            var burger = Instantiate(hamburger, spawnPoint.position, spawnPoint.rotation);
            Destroy(collision.gameObject);
            
        }
    }
}
