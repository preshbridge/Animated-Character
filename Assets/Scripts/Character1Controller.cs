using UnityEngine;

public class Character1Controller : MonoBehaviour
{
    [Header("Animator Reference")]
    [SerializeField] private Animator character1Animator;

    [Header("Dance Animation States")]
    [SerializeField] private string[] danceClips;

    private int currentClipIndex = 0;
    private bool isDancing = false;

    private void Update()
    {
        HandleDanceInput();
    }

    private void HandleDanceInput()
    {
        // Press  Space  → cycle through dance animations
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDancing = true;
            currentClipIndex = (currentClipIndex + 1) % danceClips.Length;

            character1Animator.SetBool("isDancing", isDancing);
            character1Animator.SetInteger("danceIndex", currentClipIndex);
        }

        // Press  I  → stop dancing
        if (Input.GetKeyDown(KeyCode.I))
        {
            isDancing = false;
            character1Animator.SetBool("isDancing", isDancing);
        }
    }
}
