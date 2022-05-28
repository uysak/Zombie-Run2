using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{

    private Animator PlayerAnimator;

    [SerializeField] GameObject GunIdle;
    [SerializeField] GameObject GunRun;

    

    void Start()
    {
       PlayerAnimator =  GameObject.FindGameObjectWithTag("Player").transform.GetChild(1).gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerRunAnimation()
    {
        PlayerAnimator.SetBool("isPlayerRun", true);
        PlayerAnimator.SetBool("isPlayerIdle", false);

        GunIdle.SetActive(false);
        GunRun.SetActive(true);
    }
    public void PlayerIdleAnimation()
    {
        PlayerAnimator.SetBool("isPlayerDead", false);
        PlayerAnimator.SetBool("isPlayerRun", false);
        PlayerAnimator.SetBool("isPlayerIdle", true);

        GunRun.SetActive(false);
        GunIdle.SetActive(true);
    }

    public void PlayerDeadAnimation()
    {
        PlayerAnimator.SetBool("isPlayerDead", true);
        PlayerAnimator.SetBool("isPlayerRun", false);
        PlayerAnimator.SetBool("isPlayerIdle", false);
    }

}
