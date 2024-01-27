using System;
using UnityEngine;

public class DirectionalButtonsBuffer : MonoBehaviour
{
    [SerializeField]
    private EventTriggerButton _rightEventTriggerButton;
    [SerializeField]
    private EventTriggerButton _leftEventTriggerButton;
    public Action boom;

    protected void OnEnable()
    {
        // _rightEventTriggerButton.OnPointerDown += boom; // Ok I can maybe improve on this.
    }

    protected void OnDisable()
    {
        throw new NotImplementedException();
    }

    private void AssignEvents()
    {
        
    }
}
