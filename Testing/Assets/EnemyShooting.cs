using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject bullet;
    [SerializeField] bool shotPrediction = true;
    [SerializeField] float leadDistance = 1;
    [SerializeField] float timeToFire = 1;
    [SerializeField] float bulletLifetime = 2;
    [SerializeField] float shootDistance = 7;
    [SerializeField] float bulletSpeed = 10;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector3 playerPosision = player.transform.position;
        Vector3 shootDirection = playerPosision - transform.position;
        if(shootDirection.magnitude < shootDistance && timer >= timeToFire)
        {
            if(shotPrediction) 
            { 
                Vector3 playerVel = player.GetComponent<Rigidbody2D>().velocity;
                shootDirection += playerVel * leadDistance;
            }
            timer = 0;
            shootDirection.Normalize();
            GameObject enemyBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            enemyBullet.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletSpeed; // * Time.deltaTime * 60;
            Destroy(enemyBullet, bulletLifetime);
        }
    }
}
