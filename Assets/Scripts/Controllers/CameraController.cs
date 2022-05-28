using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject Player;

    private Vector3 Offset;
    private Vector3 Target;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Offset = this.transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Target = Player.transform.position + Offset;
        this.transform.position = Vector3.Lerp(this.transform.position, Target, 15 * Time.deltaTime);
    }
}
