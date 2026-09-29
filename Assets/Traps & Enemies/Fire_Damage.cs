using Unity.VisualScripting;
using UnityEngine;

public class Fire_Damage : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindAnyObjectByType<Health>().TakeDamage(1);
        if(FindAnyObjectByType<Health>().currentHealth == 0)
        {
        collision.gameObject.SetActive(false);
        }

    }
}
