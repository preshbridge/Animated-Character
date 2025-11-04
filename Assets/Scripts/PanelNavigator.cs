using UnityEngine;

public class PanelNavigator : MonoBehaviour
{
    [Header("List all your UI panels here in order")]
    [SerializeField] private GameObject[] panels;

    private int currentPanel = 0;

    private void Start()
    {
        DisplayPanel(currentPanel);
    }

    public void GoToNext()
    {
        ChangePanel(1);
    }

    public void GoToPrevious()
    {
        ChangePanel(-1);
    }

    private void ChangePanel(int step)
    {
        if (panels == null || panels.Length == 0)
        {
            Debug.LogWarning("PanelNavigator: No panels assigned!");
            return;
        }

        // Hide the current panel
        panels[currentPanel].SetActive(false);

        // Move index forward or backward, loop around when necessary
        currentPanel += step;

        if (currentPanel >= panels.Length)
            currentPanel = 0;
        else if (currentPanel < 0)
            currentPanel = panels.Length - 1;

        // Show the new panel
        panels[currentPanel].SetActive(true);
    }

    private void DisplayPanel(int index)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == index);
        }
    }
}
