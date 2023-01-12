using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuHandler : MonoBehaviour
{
    public string playerName;
    public TMP_InputField playerNameField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif


    }

    public void SetName(string name)
    {
        playerName = playerNameField.text;
        Debug.Log("HELLO "+ playerName);
        MainManager.Instance.playerName = playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
