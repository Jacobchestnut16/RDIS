using UnityEngine;
using System.Collections;

public class InteractableCamera : MonoBehaviour
{
    public Camera objectCamera;
    public Camera mainCamera;
    public AudioSource audioSource;

    bool isPlaying;

    public void Trigger()
    {
        if (!isPlaying)
            StartCoroutine(PlaySequence());
    }

    IEnumerator PlaySequence()
    {
        isPlaying = true;

        mainCamera.enabled = false;
        objectCamera.enabled = true;

        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        objectCamera.enabled = false;
        mainCamera.enabled = true;

        isPlaying = false;
    }
}