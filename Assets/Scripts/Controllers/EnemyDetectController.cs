using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectController : MonoBehaviour
{
    private GameObject _Target;

    private bool _isEnemyDetect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            _Target = other.gameObject;
            _isEnemyDetect = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            _isEnemyDetect = false;
        }
    }

    public bool getIsEnemyDetect()
    {
        return _isEnemyDetect;
    }
    public Vector3 getTargetPos()
    {
        if(_Target == null)
        { 
            _isEnemyDetect = false;
            return new Vector3(0,0,0); 
        }

        return _Target.transform.position;
    }
}
