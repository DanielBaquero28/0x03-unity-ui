using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public Rigidbody rb;
	public float speed = 500f;

    private int score = 0;

    public int health = 5;

    void Update()
    {
        if (health == 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(0);
            health = 5;
            score = 0;
        }
    }
	void FixedUpdate()
	{
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 vector = new Vector3(horizontal * Time.deltaTime, 0.0f, vertical * Time.deltaTime);

        rb.AddForce(vector * speed);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score += 1;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }

        if (other.tag == "Trap")
        {
            health -= 1;
            Debug.Log("Health: " + health);
        }

        if (other.tag == "Goal")
        {
            Debug.Log("You win!");
        }
    }
}