using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileTrigger : EventTrigger {
    public override void OnPointerDown(PointerEventData eventData)
    {
        GetComponent<TileController>().Report();
        base.OnPointerDown(eventData);
    }
}
