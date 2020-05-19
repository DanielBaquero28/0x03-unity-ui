using System.Collections;
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
    /// <summary> UI text health </summary>
     public Text healthText;
    /// <summary>  </summary>
      public Text winLoseText;
    /// <summary>  </summary>
    public GameObject winLoseBg;

    void Update()
    {
        if (health == 0)
        {
            //Debug.Log("Game Over!");
            StartCoroutine(LoadScene(3.0f));
            LosePlayerCase();
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
            //Debug.Log("Health: " + health);
            SetHealthText();
        }

        if (other.tag == "Goal")
        {
            //Debug.Log("You win!");
            StartCoroutine(LoadScene(3.0f));
            WinPlayerCase();

        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }

    void WinPlayerCase()
    {
        winLoseText.text = "You Win!";
        winLoseText.color = Color.black;
        winLoseBg.GetComponent<Image>().color = Color.green;
        winLoseBg.SetActive(true);
    }

    void LosePlayerCase()
    {
        winLoseText.text = "Game Over!";
        winLoseText.color = Color.white;
        winLoseBg.GetComponent<Image>().color = Color.red;
        winLoseBg.SetActive(true);
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(0);
    }
}