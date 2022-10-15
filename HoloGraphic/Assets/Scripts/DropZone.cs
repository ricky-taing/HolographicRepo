using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public void OnPointerEnter(PointerEventData eventData) {
        //Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData) {
        //Debug.Log("OnPointerExit");
    }

    public void OnDrop(PointerEventData eventData) {
        Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null) {
            d.parentToReturnTo = this.transform;
        }
    }

    //https://www.youtube.com/watch?v=P66SSOzCqFU
    //useful video, 25:21 for slots/drop specific type on specific zone
    
}
