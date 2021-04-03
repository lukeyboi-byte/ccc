using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseCursor : MonoBehaviour
{
    public Vector3 mousePos;
    public Texture2D cursorArrow;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorArrow, mousePos, CursorMode.ForceSoftware);
        
        //will only work properly for the build of the game (this locks the mouse cursor within the game screen bounds)
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        Mouse();
    }

    public void Mouse()
    {
        mousePos = Input.mousePosition;

        // if (Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log("y= " + mousePos.x);
        //     Debug.Log("x= " + mousePos.y);
        // }
        
    }
}
