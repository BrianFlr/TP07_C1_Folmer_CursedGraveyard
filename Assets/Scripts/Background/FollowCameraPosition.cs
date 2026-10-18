using UnityEngine;

public class FollowCameraPosition : MonoBehaviour
{
    private Vector2 cameraPosition;

    private void LateUpdate()
    {
        cameraPosition = Camera.main.transform.position;

        transform.position = cameraPosition;
    }
}
