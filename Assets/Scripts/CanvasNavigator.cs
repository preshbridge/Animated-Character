using UnityEngine;

public class CanvasNavigator : MonoBehaviour
{
    [Header("Assign all UI canvases in order")]
    [SerializeField] private GameObject[] canvasPanels;

    private int activePanel = 0;

    private void Start()
    {
        // Ensure only the first panel is visible at start
        for (int i = 0; i < canvasPanels.Length; i++)
        {
            canvasPanels[i].SetActive(i == activePanel);
        }
    }

    public void NextPanel()
    {
        if (activePanel >= canvasPanels.Length - 1) return;

        SetPanel(activePanel + 1);
    }

    public void PreviousPanel()
    {
        if (activePanel <= 0) return;

        SetPanel(activePanel - 1);
    }

    private void SetPanel(int index)
    {
        canvasPanels[activePanel].SetActive(false);
        activePanel = index;
        canvasPanels[activePanel].SetActive(true);
    }
}
