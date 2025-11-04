using UnityEngine;

public class AudioController : MonoBehaviour
{
    [Header("Target Audio Source")]
    [SerializeField] private AudioSource audioPlayer;

    private bool isMuted = false;

    // Toggles the audio on or off
    public void ToggleAudio()
    {
        if (audioPlayer == null) return;

        isMuted = !isMuted;
        audioPlayer.mute = isMuted;
    }
}
