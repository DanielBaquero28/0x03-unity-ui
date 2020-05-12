using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 45 * Time.deltaTime, 0, Space.World);
    }
}
