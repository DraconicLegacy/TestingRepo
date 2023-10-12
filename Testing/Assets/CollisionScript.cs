using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    [SerializeField] float addedPlayerDamage = 5f;
    [SerializeField] float basePlayerDamage = 5f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Debug.Log(collision.gameObject.tag);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Coin")
        {
            Debug.Log("I got a coin!");
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Weapon") 
        {
            Debug.Log("You picked up a weapon!");
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
