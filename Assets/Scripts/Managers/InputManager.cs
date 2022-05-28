using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    private Vector2 _mouseStartPos;
    public Vector2 mousePos;
    public Vector2 Direction { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseControl();
    }

    public void MouseControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mouseStartPos = Input.mousePosition; 
        }

        if (Input.GetMouseButton(0))
        {
            mousePos = Input.mousePosition;
            var delta = new Vector2(Input.mousePosition.x, Input.mousePosition.y) - _mouseStartPos;
            Direction = delta.normalized;
        }

        else
        {
            Direction = Vector3.zero;
        }
    }

    
}
