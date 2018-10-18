using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour,IDropHandler,IPointerExitHandler{
    
    public static string location;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
       // Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       // Debug.Log("OnPointerExit");
    }
    public void OnDrop(PointerEventData eventData) {
        Debug.Log(eventData.pointerDrag.name + "was droped on" + gameObject.name);
        location = gameObject.name;
       /* if (gameObject.name == "Hand")
        {
            flag = true;
        }
        else if (gameObject.name == "Table")
        {
            flag = false;
        } */
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
              
        }
    }

    public string Decision()
    {
        Debug.Log("あげたいのは" + location);
        return location;
    }
}
