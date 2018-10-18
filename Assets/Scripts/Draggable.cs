using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler 
{
    public Transform parentToReturnTo = null;

    public Sprite spriteMae;
    public Sprite spriteAto;

    public GameObject DZ;

    public void OnBeginDrag(PointerEventData eventData)
    { 
        Debug.Log("OnBeginDrag");
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");

        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        this.transform.SetParent( parentToReturnTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        DropZone dz = DZ.GetComponent<DropZone>();
        string location = dz.Decision();
        Debug.Log(location);

        if (location == "Hand")
        {
            this.gameObject.GetComponent<Image>().sprite = spriteMae;
        }
        else
        {
            this.gameObject.GetComponent<Image>().sprite = spriteAto;
        }
        

        /*if(DZ.gameObject.GetComponent<DropZone>().flag == "Hand") {
            Debug.Log("ハンドにある");
        }
        else
        {
            Debug.Log("テーブルにある");
        }
        if(Flag.gameObject.GetComponent<DropZone>().flag == true) {
            this.gameObject.GetComponent<Image>().sprite = spriteMae;
            Debug.Log("手札のフラッグを取得");
        }
        else if(Flag.gameObject.GetComponent<DropZone>().flag == false)
        {
            this.gameObject.GetComponent<Image>().sprite = spriteAto;
            Debug.Log("テーブルのフラッグを取得");
        }*/
        
    }
    
}