using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public void Start()
    {
        Button thisButton = GetComponent<Button>();
        thisButton.onClick.AddListener(Quit);
    }

    public void Quit()
    {
        Application.Quit();
    }
}