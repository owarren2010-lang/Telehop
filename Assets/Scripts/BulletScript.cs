using UnityEngine;

public class BulletScript : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemies>().UpdateHealthBar(25);
        }
    }

}
