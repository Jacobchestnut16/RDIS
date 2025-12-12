using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetScene : MonoBehaviour
{

    [SerializeField] string sceneName;

    void Start()
    {
        Button thisButton = GetComponent<Button>();
        thisButton.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        SceneManager.LoadScene(sceneName);
    }
    
}
