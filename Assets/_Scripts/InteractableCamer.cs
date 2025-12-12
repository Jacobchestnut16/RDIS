using UnityEngine;
using System.Collections;

public class InteractableCamera : MonoBehaviour
{
    public Camera objectCamera;
    public Camera mainCamera;
    public AudioSource audioSource;

    bool isPlaying = false;

    public void Trigger()
    {
        if (!isPlaying)
            StartCoroutine(PlaySequence());
    }

    private IEnumerator PlaySequence()
    {
        isPlaying = true;

        objectCamera.enabled = true;
        mainCamera.enabled = false;
        
        if (!objectCamera.enabled)
            objectCamera.enabled = true;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        mainCamera.enabled = true;
        objectCamera.enabled = false;

        isPlaying = false;
    }
}