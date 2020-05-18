using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary> Class in charge of controlling the Player </summary>
public class PlayerController : MonoBehaviour
{
    /// <summary> Player's RigidBody </summary>
	public Rigidbody rb;
     /// <summary> Player's speed </summary>
	public float speed = 500f;
     /// <summary> Player's score </summary>
    private int score = 0;
    /// <summary> Player's health </summary>
    public int health = 5;
    /// <summary> UI text score </summary>
    public Text scoreText;

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
            //Debug.Log("Score: " + score);
            SetScoreText();
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

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}