using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Viapix_PlayerParams;

namespace Viapix_HealingItem
{
    public class Viapix_HealingItem : MonoBehaviour
    {
        [SerializeField]
        float rotationSpeedX, rotationSpeedY, rotationSpeedZ;

        [SerializeField]
        int healingAmount = 20;

        GameObject playerObj;

      

        void Update()
        {
            transform.Rotate(rotationSpeedX, rotationSpeedY, rotationSpeedZ);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<PlayerHealth>().Health(healingAmount);

                Destroy(gameObject);
            }
        }
    }
}

