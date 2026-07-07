using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Project : MonoBehaviour
{

    string name = "Orlando";
    int x = 15;
    float height = 5.00f;
    bool Coding = true;
    void Start() 
    {
        Debug.Log("Hello " + name);
        Debug.Log("You are " + x);
        Debug.Log("You are 5 foot tall");

        if (Coding == true)
        {
            Debug.Log("You like Coding");
        }
        else
        {
            Debug.Log("You hate Coding");
        }

            if (x <= 18)
            {
                Debug.Log("You're a Minor");
            }
            else
            {
                Debug.Log("You're an Adult");
            }
    }  
    
}
