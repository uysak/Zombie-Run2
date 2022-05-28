using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x > 35 || this.transform.position.x < -35 || this.transform.position.z > 35 || this.transform.position.z < -35)
        {
         //   Destroy(this.gameObject);
        }
        this.transform.Translate(0, 0, 40 * Time.deltaTime);
    }
}


// 0.07056778 0.908946  -1.226078
// 6.323  -3.636 -0.608