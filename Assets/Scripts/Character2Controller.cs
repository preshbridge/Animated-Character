using UnityEngine;

public class Character2Controller : MonoBehaviour
{
    [Header("Animator Reference")]
    [SerializeField] private Animator character2Animator;

    [Header("Dance Animations")]
    [SerializeField] private string[] danceAnimations;

    private int activeDance = 0;
    private bool isDancing = false;

    private void Update()
    {
        CheckDanceControls();
    }

    private void CheckDanceControls()
    {
        // Cycle through available dances when Space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDancing = true;
            activeDance = (activeDance + 1) % danceAnimations.Length;

            character2Animator.SetBool("isDancing", isDancing);
            character2Animator.SetInteger("danceIndex", activeDance);
        }

        // Stop dancing when 'I' is pressed
        if (Input.GetKeyDown(KeyCode.I))
        {
            isDancing = false;
            character2Animator.SetBool("isDancing", isDancing);
        }
    }
}
