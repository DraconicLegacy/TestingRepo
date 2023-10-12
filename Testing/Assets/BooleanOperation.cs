using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanOperation : MonoBehaviour
{
    // [SerializeField]
    bool hasCakeMix = true;
    bool hasEggs = true;
    bool hasFlour = true;
    bool hasOil = true;
    bool hasSugar  = true;
    bool hasMilk = true;
    bool hasMoney = true;
    

    // Start is called before the first frame update
    void Start()
    {
        if(hasMoney) 
        {
            Debug.Log("Ubereats gonna bring me some cake! >:D");
        }

        else if(hasCakeMix) 
        {
            Debug.Log("Gonna make a Cake mix!!");
        }

        else if(hasEggs && hasFlour && hasOil && hasSugar && hasMilk)
        {
            Debug.Log("Scratch Cake!!!");
        }

        else
        {
            Debug.Log("I is sad I has no Cake D:");
        }

        if(hasMoney || hasCakeMix || hasEggs && hasFlour && hasMilk && hasOil && hasSugar)
        {
            Debug.Log("I HAS CAKE!!!!");
        }

        else
        {
            Debug.Log("I is sad, I has no Cake D:");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
