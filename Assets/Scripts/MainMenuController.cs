using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonsController : MonoBehaviour
{
    [Header("Next Scene Name")]
    [SerializeField] private string nextCharacterScene = "CharacterSelect2"; // Change to your scene name

    /// <summary>
    /// Called when the Exit button is pressed
    /// </summary>
    public void OnExitPressed()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stops play mode in editor
#else
        Application.Quit(); // Quits the built game
#endif

        Debug.Log("Exit button pressed!");
    }

    /// <summary>
    /// Called when the Next Character button is pressed
    /// </summary>
    public void OnNextCharacterPressed()
    {
        if (string.IsNullOrEmpty(nextCharacterScene))
        {
            Debug.LogWarning("Next character scene not assigned in Inspector!");
            return;
        }

        // Check if the scene is in Build Settings
        if (Application.CanStreamedLevelBeLoaded(nextCharacterScene))
        {
            Debug.Log("Loading next character scene: " + nextCharacterScene);
            SceneManager.LoadScene(nextCharacterScene);
        }
        else
        {
            Debug.LogError("Scene '" + nextCharacterScene + "' is not added to Build Settings!");
        }
    }
}
