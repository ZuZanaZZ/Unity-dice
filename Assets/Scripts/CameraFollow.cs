using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform dice;
    public float smoothTime;
    public Vector3 offset;
    public Vector3 velocity = Vector3.zero;
    
    void Update()
    {
        Vector3 desiredPosition = dice.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
        // if velocity is very small, set it to zero
        if (Vector3.Distance(smoothedPosition, desiredPosition) < 1)
        {
            velocity = Vector3.zero;
        }
        
        transform.position = smoothedPosition;
    }
}
