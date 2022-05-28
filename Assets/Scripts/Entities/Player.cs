using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("fail");
            gameManager.GameFail();
        }
        else if (other.gameObject.CompareTag("LandingArea"))
        {
            Debug.Log("landing");
        }
    }
}

//-0.081 0.894  0.625

//    0 -21.369 0
