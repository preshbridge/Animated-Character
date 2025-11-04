using UnityEngine;

public class PanelNavigator : MonoBehaviour
{
    [Header("UI Panels in this scene")]
    [SerializeField] private GameObject[] panels;

    private int currentPanelIndex = 0;

    private void Start()
    {
        ShowPanel(currentPanelIndex);
    }

    public void ShowNext()
    {
        currentPanelIndex = (currentPanelIndex + 1) % panels.Length;
        ShowPanel(currentPanelIndex);
    }

    public void ShowPrevious()
    {
        currentPanelIndex--;
        if (currentPanelIndex < 0)
            currentPanelIndex = panels.Length - 1;

        ShowPanel(currentPanelIndex);
    }

    private void ShowPanel(int index)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == index);
        }
    }

    public void ShowPanelByIndex(int index)
    {
        if (index >= 0 && index < panels.Length)
        {
            currentPanelIndex = index;
            ShowPanel(currentPanelIndex);
        }
    }
}
