using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    InputManager inputManagerScript;
    [SerializeField] private float _movementSpeed;
    // Start is called before the first frame update
    EnemyDetectController enemyDetectController;

    AnimationManager animationManager;

    private bool isPlayerMove;

    void Start()
    {
        animationManager = GameObject.FindGameObjectWithTag("AnimationManager").GetComponent<AnimationManager>();
        enemyDetectController = GameObject.FindGameObjectWithTag("EnemyDetect").GetComponent<EnemyDetectController>();
        inputManagerScript = this.GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if(enemyDetectController.getIsEnemyDetect() == false)
        {
            LookAtMouse();
        }
        else
        {
            LookAtEnemy();
        }


        Move();
        CheckIsPlayerMove();

    }


    void CheckIsPlayerMove()
    {
        if (Input.GetMouseButton(0))
        {
            isPlayerMove = true;
            animationManager.PlayerRunAnimation();
        }
        else
        {
            isPlayerMove = false;
            animationManager.PlayerIdleAnimation();
        }

    }
    void LookAtMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        Vector3 objectPos = UnityEngine.Camera.main.WorldToScreenPoint(transform.position);

        mousePos.x = objectPos.x - mousePos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0, angle - 90, 0 ), 10 * Time.deltaTime);

    }

    void LookAtEnemy()
    {
        this.transform.LookAt(Vector3.Lerp(this.transform.position, enemyDetectController.getTargetPos(), 0.2f * Time.deltaTime));
    }

    private void Move()
    {
        this.transform.position += new Vector3(inputManagerScript.Direction.x, 0, inputManagerScript.Direction.y) * _movementSpeed * Time.deltaTime;
    }
}
