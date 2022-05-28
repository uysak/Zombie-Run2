using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{

    private GameObject _Target;
    EnemyDetectController enemyDetectController;
    RescueAreaManager rescueAreaManager;

    // Start is called before the first frame update
    void Start()
    {
        enemyDetectController = this.GetComponent<EnemyDetectController>();
        rescueAreaManager = GameObject.FindGameObjectWithTag("RescueArea").GetComponent<RescueAreaManager>();

        rescueAreaManager.AddSoldier(this.gameObject);


    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            _Target = other.gameObject;
        }
    }

    public void TurnToTarget()
    {
        this.transform.LookAt(Vector3.Lerp(this.transform.position, enemyDetectController.getTargetPos(),0.2f * Time.deltaTime));
    }

}
