using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float chaseDistance = 5;
    [SerializeField] float moveSpeed = 5;
    Vector3 home;
    private void Start()
    {
        home = transform.position;
    }
    void Update()
    {
        Vector3 playerPosision = player.transform.position;
        Vector3 moveDirection = playerPosision - transform.position;
        //If player is close

        if(moveDirection.magnitude < chaseDistance)
        {
            moveDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = moveDirection * moveSpeed; // * Time.deltaTime * 60;
        }

        else
        {
            moveDirection = home - transform.position;

            if (moveDirection.magnitude >= 0.15f)
            {
                moveDirection.Normalize();
                GetComponent<Rigidbody2D>().velocity = moveDirection * moveSpeed;
            }
            else
            {
                transform.position = home;
                GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            }
        }
    }
}
