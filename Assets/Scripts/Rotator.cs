using UnityEngine;

 /// <summary> Class in charge of the rotation of the coins </summary>
public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 45 * Time.deltaTime, 0, Space.World);
    }
}
