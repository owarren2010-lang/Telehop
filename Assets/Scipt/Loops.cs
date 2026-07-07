using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
   

    void Start()
    {
        for(int l = 10; l >= 1; l--)
        { 
           if(l == 0)
            {
            
            }
            else
            {
            Debug.Log(l);   

            }
          
        }

                for (int m = 0; m <= 10; m++)
                {
                int n = m;
                 n = m * n;
                    if (n <= 1000)
                    {
                    Debug.Log(n);
                    }
                    else
                    {
                    

                    }

                }
    }

   
}
