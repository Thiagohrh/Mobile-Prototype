using System;
using UnityEngine.EventSystems;

public class EventTriggerButton : EventTrigger
{
    public Action OnClickDown;
    public Action OnClickUp;
    public override void OnPointerDown(PointerEventData eventData)
    {
        OnClickDown?.Invoke();
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        OnClickUp?.Invoke(); // Not sure I need this one, just in case.
    }
}
