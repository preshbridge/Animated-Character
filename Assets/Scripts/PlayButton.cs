using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonController : MonoBehaviour
{
    [Header("Scene to load when Play is pressed")]
    [Tooltip("Make sure this scene is added to Build Settings!")]
    [SerializeField] private int gameSceneBuildIndex = 1; // Default index (0 = first scene)

    public void OnPlayPressed()
    {
        if (gameSceneBuildIndex >= 0 && gameSceneBuildIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(gameSceneBuildIndex);
        }
        else
        {
            Debug.LogError($"Scene at build index {gameSceneBuildIndex} is not in Build Settings!");
        }
    }
}