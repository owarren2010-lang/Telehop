using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNightCycle : MonoBehaviour
{
    public Light sunLight;
    public float daySpeed = 10f;

    
    void Update()
    {
     SunMove();
        
    }

private void SunMove()
    {
        sunLight.transform.Rotate(Vector3.right * daySpeed * Time.deltaTime);
        float angle = sunLight.transform.rotation.eulerAngles.x;
        if (angle > 180) angle -= 360;
        if (angle > -10 && angle < 170)
        {
            sunLight.intensity = 1f;
            sunLight.color = Color.white;
        }
        else
        {
            sunLight.intensity = 0.1f;
            sunLight.color = new Color(0.2f, 0.2f, 0.6f);
        }
    }
}
