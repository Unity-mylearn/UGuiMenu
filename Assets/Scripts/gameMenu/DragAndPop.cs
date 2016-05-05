using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class DragAndPop : MonoBehaviour,IDragHandler,IPointerDownHandler,IPointerUpHandler {
    [SerializeField]
    private Camera uiCamera;
    public void OnDrag(PointerEventData eventData) {
        GetComponent<RectTransform>().pivot.Set(0, 0);
        transform.position = uiCamera.ScreenToViewportPoint(Input.mousePosition);
    }

    public void OnPointerDown(PointerEventData eventData) {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    public void OnPointerUp(PointerEventData eventData) {
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
