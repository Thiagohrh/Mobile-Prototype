using System;
using UnityEngine.EventSystems;

public class EventTriggerButton : EventTrigger
{
    public Action OnClickDown;
    public override void OnPointerDown(PointerEventData eventData)
    {
        OnClickDown?.Invoke();
    }
}
