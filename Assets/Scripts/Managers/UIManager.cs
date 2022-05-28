using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{

    [SerializeField] GameObject GameOverPanel;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

    }

    public void RestartGame()
    {
        gameManager.RestartGame();
    }
    
    public void StartGame()
    {
        gameManager.StartGame();
    }


    public void SetVisibleGameOverPanel()
    {
        GameOverPanel.SetActive(true);
    }
    public void SetUnvisibleGameOverPanel()
    {
        GameOverPanel.SetActive(false);
    }
}
