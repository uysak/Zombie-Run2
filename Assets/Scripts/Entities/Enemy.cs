using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    EnemyMovementManager enemyMovementManagerScript;
    private float _movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _movementSpeed = .3f;
        enemyMovementManagerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<EnemyMovementManager>();
        enemyMovementManagerScript.AddEnemy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            enemyMovementManagerScript.DestroyEnemy(this.gameObject);
        }
    }

    public void Follow(GameObject WhoFollowed)
    {
        this.transform.LookAt(WhoFollowed.transform);

        this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(WhoFollowed.transform.position.x, WhoFollowed.transform.position.y, WhoFollowed.transform.position.z), _movementSpeed * Time.deltaTime);
    }
}
