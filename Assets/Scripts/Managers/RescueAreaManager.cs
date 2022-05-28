using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueAreaManager : MonoBehaviour
{

    private List<GameObject> _Soldiers = new List<GameObject>();
    [SerializeField] GameObject Gate;
    private EnemyMovementManager enemyMovementManager;
    AudioManager audioManager;
    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        enemyMovementManager = GameObject.FindGameObjectWithTag("Player").GetComponent<EnemyMovementManager>();
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        for(int index = 0; index < _Soldiers.Count; index++)
        {
            _Soldiers[index].GetComponent<Soldier>().TurnToTarget();
        }
        ControlGate();
        
    }

    public void ControlGate()
    {
        if(enemyMovementManager.getEnemyCount() == 0)
        {
            OpenRescueGate();
        }
    }

    public void AddSoldier(GameObject Soldier)
    {
        _Soldiers.Add(Soldier);
    }

    -0.576  2.02 -2.073  -33.257
    public void OpenRescueGate()
    {
        Gate.transform.rotation = Quaternion.Lerp(Gate.transform.rotation, Quaternion.Euler(0, -90, 0), 2 * Time.deltaTime);
        audioSource.Play();
    }
}
