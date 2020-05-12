using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset = new Vector3(-1f, 24.75f, -9);

    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
