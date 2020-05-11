using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public Rigidbody rb;
	public float speed = 500f;

	void FixedUpdate()
	{
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 vector = new Vector3(horizontal * Time.deltaTime, 0.0f, vertical * Time.deltaTime);

        rb.AddForce(vector * speed);
	}
}