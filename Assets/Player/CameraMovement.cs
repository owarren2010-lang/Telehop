using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Target")]
    public Transform player;

    [Header("Camera Settings")]
    public float smoothSpeed = 5f;
    public Vector3 offset = new Vector3 (0f, 1f, -10f);

   



    void LateUpdate()
    {
        if (player == null)
            return;
        Vector3 targetPosition = player.position + offset;

        transform.position = Vector3.Lerp(
        transform.position, targetPosition, smoothSpeed * Time.deltaTime);

    }
    
}
