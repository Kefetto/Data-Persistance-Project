using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuHandler : MonoBehaviour
{
    static public string playerNameMenu;
    public TMP_InputField playerNameField;
    public TextMeshProUGUI bestScoreText;
    private string playerNameSaved;
    private int bestScore;

    // Start is called before the first frame update
    private void Start()
    {
        SetBestPlayer();
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

    public void SetName()
    {
        playerNameMenu = playerNameField.text;

        Debug.Log("HELLO "+ playerNameMenu);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBestPlayer()
    {
        LoadSaveBest();
        

        bestScoreText.text = "Best Score : " + playerNameSaved + " : " + bestScore;
        
    }
    [System.Serializable]
    class SaveDataName
    {
        public string playName;
        public int score;
    }

    public void LoadSaveBest()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveDataName SavingData = JsonUtility.FromJson<SaveDataName>(json);

            playerNameSaved = SavingData.playName;
            bestScore = SavingData.score;

            Debug.Log(playerNameSaved + bestScore);

        }
    }

}
