using UnityEngine;

public class Character3Controller : MonoBehaviour
{
    [Header("Animator Reference")]
    [SerializeField] private Animator characterAnimator;

    [Header("Dance Animation Clips")]
    [SerializeField] private string[] danceClips;

    private int currentClip = 0;
    private bool dancing = false;

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        // Move to the next dance clip when Space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dancing = true;
            currentClip = (currentClip + 1) % danceClips.Length;

            characterAnimator.SetBool("isDancing", dancing);
            characterAnimator.SetInteger("clipIndex", currentClip);
        }

        // Stop dancing when I is pressed
        if (Input.GetKeyDown(KeyCode.I))
        {
            dancing = false;
            characterAnimator.SetBool("isDancing", dancing);
        }
    }
}
