using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    public Funding funding;
    public Popularity popularity;
    public Collider2D scenarioStampingCol;
    public bool isStamp;

    private RectTransform rectTransform;

    public void Start()
    {
        if (funding == null)
        {
            return;
        }

        if (popularity == null)
        {
            return;
        }

        if (scenarioStampingCol == null)
        {
            return;
        }
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //here is where I need to work out stamping with instant outcome
        
        Debug.Log("OnEndDrag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other == scenarioStampingCol)
        {
            funding.InstantFundsOutcome();
            popularity.InstantPopOutcome();
        }
    }
}
