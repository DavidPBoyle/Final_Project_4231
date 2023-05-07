using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public Transform player;
    public float detectionRange;
    public GameObject throwableObject;
    public float throwForce;

    private bool isThrowing = false;

    void Update()
    {
        // Check if the player is within range
        if (Vector3.Distance(transform.position, player.position) <= detectionRange && !isThrowing)
        {
            isThrowing = true;
            StartCoroutine(ThrowObject());
        }
    }

    IEnumerator ThrowObject()
    {
        // Instantiate a throwable object and apply a force to it
        GameObject throwable = Instantiate(throwableObject, transform.position, Quaternion.identity);
        Rigidbody throwableRb = throwable.GetComponent<Rigidbody>();
        Vector3 throwDirection = (player.position - transform.position).normalized;
        throwableRb.AddForce(throwDirection * throwForce, ForceMode.Impulse);

        // Wait for the object to finish throwing before allowing the enemy to throw again
        yield return new WaitForSeconds(0.5f);
        isThrowing = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the thrown object collided with the enemy
        if (collision.gameObject == throwableObject)
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
        else if (collision.gameObject.CompareTag("player"))
        {
            // Do something to the player, such as dealing damage or triggering a game over
        }
    }
}

