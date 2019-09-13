using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dragging : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Vector2 VertBounds;
    public Vector2 HoriBounds;
    bool isDragging;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - startPos;
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, HoriBounds.x, HoriBounds.y),
                Mathf.Clamp(transform.position.y, VertBounds.x, VertBounds.y));
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;
        startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }
}