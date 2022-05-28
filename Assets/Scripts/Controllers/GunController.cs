using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private List<GameObject> BulletList = new List<GameObject>();
    [SerializeField]AudioSource audioSource;
    
    [SerializeField] GameObject Player;

    private Player playerScript;
    EnemyDetectController enemyDetectController;

    AudioManager audioManager;


    private GameObject _Target;
    [SerializeField] GameObject Bullet;


    [SerializeField] float bulletBorder;
    private int Distance;


    // -0.197 0.952 -0.629   -0.629 -44.367 -0.206

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        enemyDetectController = Player.GetComponent<EnemyDetectController>();
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    private void OnEnable()
    {
        InvokeRepeating("GunShot", 1, 0.2f);
    }
    private void OnDisable()
    {
        CancelInvoke("GunShot");
    }

    void Update()
    {
        CheckBulletOutside();
    }

    private void CheckBulletOutside()
    {


        for(int index = 0; index < BulletList.Count; index++)
        {
            if(BulletList[index] != null)
                Distance = (int) Vector3.Distance(BulletList[index].transform.position, this.transform.position);
            if (BulletList[index] == null || Distance > bulletBorder)
            {
                Destroy(BulletList[index]);
                BulletList.RemoveAt(index);

            }
        }

        //foreach(GameObject Bullet in BulletList)
        //{
        //    Distance = (int)Vector3.Distance(Bullet.transform.position,this.transform.position);
        //    if(Bullet == null || Distance > 8)
        //    {
        //        BulletList.Remove(Bullet);
        //        Destroy(Bullet);
        //    }
        //}
    }

    private void GunShot()
    {
        if( (  enemyDetectController.getTargetPos() != null && enemyDetectController.getIsEnemyDetect() == true ) && playerScript.isPlayerCanShoot == true)
        {
            audioManager.GunShoot(audioSource);
            Vector3 target = new Vector3(this.transform.position.x + 6.1f, this.transform.position.y + 1.9674f,  this.transform.position.z - 21.6f);
            BulletList.Add(Instantiate(Bullet, this.transform.position, this.transform.rotation));
        }
    }
}

// 5.965   2.612   -21.75

// - 0.133 0.6446  - 0.15
