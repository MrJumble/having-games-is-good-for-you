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

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static string roomPurpose;
    public static int sceneNum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
