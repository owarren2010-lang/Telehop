using UnityEngine;

public class Insta_Kill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collsion)
    {
        FindAnyObjectByType<Health>().TakeDamage(3);
        collsion.gameObject.SetActive(false);
    }


}
