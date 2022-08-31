using UnityEngine.SceneManagement;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public Text BestScoreText;


    void Start()
    {
        BestScoreText.text = $"Best Score : {Manager.Instance.UserName} : {Manager.Instance.BestScore}";
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        Manager.Instance.SaveData();
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

    public void OnChangeName(string name)
    {
        Manager.Instance.UserName = name;
        BestScoreText.text = $"Best Score : {Manager.Instance.UserName} : {Manager.Instance.BestScore}";
    }
}
