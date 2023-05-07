using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;

    private int currentPoint = 0;
    // Update is called once per frame
    void Update()
    {
        // Move towards the current patrol point
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, moveSpeed * Time.deltaTime);

        // If the enemy reaches the current patrol point, switch to the next one
        if (transform.position == patrolPoints[currentPoint].position)
        {
            currentPoint++;
            if (currentPoint >= patrolPoints.Length)
            {
                currentPoint = 0;
            }
        }
    }
}
