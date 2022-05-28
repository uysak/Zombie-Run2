using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    UIManager uiManager;
    AnimationManager animationManager;
    // Start is called before the first frame update
    void Start()
    {
        animationManager = GameObject.FindGameObjectWithTag("AnimationManager").GetComponent<AnimationManager>();
        uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GameFail()
    {
        uiManager.SetVisibleGameOverPanel();
        animationManager.PlayerDeadAnimation();
    }

    public void RestartGame()
    {
        uiManager.SetUnvisibleGameOverPanel();
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
       
    }

}
