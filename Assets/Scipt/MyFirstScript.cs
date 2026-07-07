 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{

    int a = 20;
    int b = 40;
    int c = 60;
    int d = 100;
    int e = 30;
    int f = 0;
    void Start()
    {
        /* c = a + b;
         Debug.Log("My other Number is " + c);
         c = a * b;
         Debug.Log("My number is " + a);
         Debug.Log("My other Number is " +c);
        f = 20 +(40 * 60) + 100 - 30;
        Debug.Log("My Answer is "+ f);
        if( a > c)
        {
            Debug.Log("a is greater than c");
        }else
        {
            Debug.Log("C is greater than a ");
        }*/

        if (c < d)
        {
            Debug.Log("D is greater than C");
        }
        else
        {
            Debug.Log("C is greater than D ");
        }

            if (b > a)
            {
                Debug.Log("B is greater than A");
            }
            else
            {
                Debug.Log("A is greater than B ");
            }

                if (d == b+c)
                {
                    Debug.Log("D Equals A+B");
                }
                else
                {
                    Debug.Log("D Does Not Equal A + B ");
                }

                    if (f<=a)
                    {
                        Debug.Log("A is greater than F");
                    }
                    else
                    {
                        Debug.Log("F is greater than A ");
                    }

                        if (e >= e)
                        {
                            Debug.Log("E Equals E");
                        }
                        else
                        {
                            Debug.Log("E does not equal E");
                        }
    }

  
}
