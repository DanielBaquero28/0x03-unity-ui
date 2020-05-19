using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary> Class in charge of controlling the Main Menu </summary>
public class MainMenu : MonoBehaviour
{
    /// <summary> Loads the Maze game scene </summary>
    public void PlayMaze()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary> Exits the game </summary>
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
