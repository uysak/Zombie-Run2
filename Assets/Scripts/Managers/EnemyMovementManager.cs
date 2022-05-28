using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementManager : MonoBehaviour
{

    private List<GameObject> _Enemies = new List<GameObject>();
    private GameObject Player;
    private float _movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        foreach(GameObject enemy in _Enemies){
            enemy.GetComponent<Enemy>().Follow(this.gameObject);



            //enemy.GetComponent<Enemy>().Follow(this.gameObject);
            //if(enemy.transform.position.y > 8.5)
            //{
            //    enemy.transform.position = new Vector3(enemy.transform.position.x,8.5f,enemy.transform.position.z);
            //}
        }
        
    }
    public void AddEnemy(GameObject Enemy)
    {
        _Enemies.Add(Enemy);
    }

    public void DestroyEnemy(GameObject Enemy)
    {
        _Enemies.Remove(Enemy);
        Destroy(Enemy);
    }

    public int getEnemyCount()
    {
        return _Enemies.Count;
    }
}
