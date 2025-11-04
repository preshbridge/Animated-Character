using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonController : MonoBehaviour
{
    [Header("Scene To Load")]
    [SerializeField] private string sceneToLoad = "Start";

    // Called when the Play button is clicked
    public void HandlePlayButton()
    {
        if (string.IsNullOrEmpty(sceneToLoad))
        {
            Debug.LogWarning("No scene name has been assigned in the Inspector!");
            return;
        }

        SceneManager.LoadScene(sceneToLoad);
    }
}
