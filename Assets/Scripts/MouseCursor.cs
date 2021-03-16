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
    }

    // Update is called once per frame
    void Update()
    {
        Mouse();
        
        //hello
    }

    public void Mouse()
    {
        mousePos = Input.mousePosition;
        
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("y= " + mousePos.x);
            Debug.Log("x= " + mousePos.y);
        }
    }
}
