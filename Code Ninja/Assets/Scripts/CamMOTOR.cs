using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class CamMOTOR : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler {
    private Image backGround;
    private Image joyStickImage;
    private Vector3 inputVector;

    private void Start()
    {
        backGround = GetComponent<Image>();
        joyStickImage = transform.GetChild(0).GetComponent<Image>();
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(backGround.rectTransform, ped.position, ped.pressEventCamera, out pos))
        
            Debug.Log("heey");
        


    }


    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {

    }
    
    }

