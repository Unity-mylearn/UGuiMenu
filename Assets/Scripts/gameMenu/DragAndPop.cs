using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class DragAndPop : MonoBehaviour,IDragHandler,IPointerDownHandler,IPointerUpHandler {
    [SerializeField]
    private Camera uiCamera;
	private RectTransform tt;

	[SerializeField]
	private Tai tai;

    public void OnDrag(PointerEventData eventData) {
		SetDraggedPosition (eventData);
    }

	private void SetDraggedPosition(PointerEventData eventData){
		Vector3 gobalPosition;
		if (RectTransformUtility.ScreenPointToWorldPointInRectangle 
			(tt, eventData.position, eventData.pressEventCamera, out gobalPosition)) {
			gobalPosition.z = 0;
			tt.position = gobalPosition;	
		}
	}

    public void OnPointerDown(PointerEventData eventData) {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
		switch (tai) {
		case Tai.SHEQU:
			commonS.info = commonS.info_shequ;
			commonS.result [0] = true;
			break;
		case Tai.TAIK:
			commonS.info = commonS.info_tak;
			commonS.result [1] = true;
			break;
		case Tai.EDU:
			commonS.info = commonS.info_edu;
			break;
		}
    }

    public void OnPointerUp(PointerEventData eventData) {
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    // Use this for initialization
    void Start () {
		tt = transform.GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
