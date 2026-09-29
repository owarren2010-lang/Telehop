using Microsoft.Win32.SafeHandles;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float projectileSpeed = 10f;
    public float Cooldown = 0f;

    void Update()
    {
        Cooldown += Time.deltaTime;
        if(Input.GetMouseButton(0) && Cooldown > 2f)
        {
            Shoot();
            Cooldown = 0f;
        }
     
    }
    void Shoot()
    {
        // Get Mouse Position In World Space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        //Calculate Direction
        Vector2 direction = (mousePosition - firePoint.position).normalized;

        //Create Projectile
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);

        // Give Projectile Velocity
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction * projectileSpeed; 

        // Rotate Projectile toward movement direction

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 
        projectile.transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
