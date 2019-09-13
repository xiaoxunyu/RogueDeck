using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dragging : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Vector2 VertBounds;
    public Vector2 HoriBounds;
    bool isDragging;
    Vector3 mouseStartPos;
    Vector3 selfStartPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = selfStartPos + Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseStartPos;
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, HoriBounds.x, HoriBounds.y),
                Mathf.Clamp(transform.position.y, VertBounds.x, VertBounds.y));
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;
        mouseStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        selfStartPos = transform.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }
}