using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_Scipt : MonoBehaviour
{
    public GameObject bulletEffectPrefab;
    public float maxDistance = 100f;
    public LayerMask workingLayers;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
    if (Input.GetMouseButtonDown(0))
        {
            FireRayFromCamera();
        }
    }

    void FireRayFromCamera()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxDistance, workingLayers))
        {
            Debug.Log("Ray hit: " + hit.collider.gameObject.name);

            if (bulletEffectPrefab != null)
            {
                GameObject effect = Instantiate(bulletEffectPrefab, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(effect, 1f);
                if (hit.collider.tag == "Enemy")
                {
                    hit.collider.gameObject.GetComponent<A_I_Copy>().Take_Damage(10);
                }
            }
        }
    }
}
