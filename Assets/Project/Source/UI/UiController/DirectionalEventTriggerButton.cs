using System;
using UnityEngine.EventSystems;

public class DirectionalEventTriggerButton : EventTrigger
{
    public Action<DirectionalInputEnum> OnClickDown;
    public Action OnClickUp;
    private DirectionalInputEnum _myDirection;

    protected void Start()
    {
        _myDirection = transform.GetComponent<DirectionalButtonIdentifier>().MyDirectionalIdentifier;
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        OnClickDown?.Invoke(_myDirection);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        OnClickUp?.Invoke();
    }
}