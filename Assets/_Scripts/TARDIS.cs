using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TARDIS : MonoBehaviour
{
    [SerializeField] string sceneName;


    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneName);
        
    }
}
