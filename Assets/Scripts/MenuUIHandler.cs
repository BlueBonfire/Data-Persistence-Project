using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public GameObject playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName.GetComponent<Text>().text = DataManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
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
        Application.Quit(); // original code to quit Unity player
#endif
    }
    public void PlayerNameChanged()
    {
        DataManager.Instance.playerName = playerName.GetComponent<Text>().text;
    }
}
