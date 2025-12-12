using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // smooth camera follow from: https://www.youtube.com/watch?v=MFQhpwc6cKE
    public Transform target;
    public float smoothTime = 0.5f;
    public Vector3 offset;
    public Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
        // vector comparison from: https://discussions.unity.com/t/compare-vector3/136577/2
        if (Vector3.Distance(smoothedPosition, desiredPosition) < 1)
        {
            velocity = Vector3.zero;
        }
        transform.position = smoothedPosition;
    }
}
