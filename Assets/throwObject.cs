using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwObject : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject projectile;
    public float speed = 10f;

    public void update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            var rock = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
            rock.GetComponent<Rigidbody>().velocity = spawnPoint.forward * speed;
        }
    }
}
