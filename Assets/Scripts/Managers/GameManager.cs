using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    UIManager uiManager;
    AnimationManager animationManager;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
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
        Player.GetComponent<PlayerMovementController>().enabled = false;
        Player.GetComponent<Player>().isPlayerCanShoot = false;
    }

    public void RestartGame()
    {
        Player.GetComponent<Player>().isPlayerCanShoot = true;
        uiManager.SetUnvisibleGameOverPanel();
        SceneManager.LoadScene(0);
        Player.GetComponent<PlayerMovementController>().enabled = true;
    }

    public void StartGame()
    {
       
    }

}
