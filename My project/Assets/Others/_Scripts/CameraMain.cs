using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The player or object to follow
    public Vector3 offset = new Vector3(0, 10, -10); // Offset of the camera from the target
    public float smoothSpeed = 0.125f; // Smooth speed for camera movement

    void LateUpdate()
    {
        if (target != null)
        {
            // Desired position based on target's position and offset
            Vector3 desiredPosition = target.position + offset;

            // Smoothly interpolate between the current position and desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Apply the smoothed position to the camera
            transform.position = smoothedPosition;

            // Ensure the camera is always looking at the target
            transform.LookAt(target);
        }
    }
}
