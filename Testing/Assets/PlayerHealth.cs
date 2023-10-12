using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int healthPackValue = 5;
    [SerializeField] int health = 100;
    int maxHealth = 100;
    [SerializeField] TextMeshProUGUI myText;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            health--;
            myText.text = "Health" + health;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            myText.text = "Health" + health;
        }

        if (collision.gameObject.tag == "Trap")
        {
            health--;
            myText.text = "Health" + health;
        }

        if (collision.gameObject.tag == "Healthpack")
        {
            Destroy(collision.gameObject);
            health += healthPackValue;
            myText.text = "Health" + health;
            if (health > maxHealth)
            { 
                health = maxHealth;
                myText.text = "Health" + health;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
