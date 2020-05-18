using UnityEngine;

/// <summary> This Class is in charge of controlling the Camera </summary>
public class CameraController : MonoBehaviour
{
/// <summary> GameObject that will be followed by the camera </summary>
    public GameObject target;
/// <summary> Camera's offset </summary>
    public Vector3 offset = new Vector3(-1f, 24.75f, -9);

    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
