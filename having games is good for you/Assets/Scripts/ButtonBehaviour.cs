using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEditor;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.UIElements;
using System;

public class ButtonBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeaveVillage()
    {
        SceneManager.LoadScene(1);
    }

}
