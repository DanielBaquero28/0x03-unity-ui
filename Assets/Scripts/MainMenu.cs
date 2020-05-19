using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary> Class in charge of controlling the Main Menu </summary>
public class MainMenu : MonoBehaviour
{
    /// <summary> Trap Material </summary>
    public Material trapMat;
    /// <summary> Goal Material </summary>
    public Material goalMat;
    /// <summary> ColorBlind Mode Toggle </summary>
    public Toggle colorblindMode;
    /// <summary> Loads the Maze game scene </summary>
    public void PlayMaze()
    {
        if (colorblindMode.isOn)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = Color.red;
            goalMat.color = Color.green;
        }

        SceneManager.LoadScene(1);
    }

    /// <summary> Exits the game </summary>
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
