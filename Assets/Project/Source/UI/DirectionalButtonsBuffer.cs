using System;
using UnityEngine;

public class DirectionalButtonsBuffer : MonoBehaviour
{
    [SerializeField]
    private EventTriggerButton _rightEventTriggerButton;
    [SerializeField]
    private EventTriggerButton _leftEventTriggerButton;

    public event Action<float> DirectionalEventInput;

    private float _currentDirectionalInput = 0.0f;

    protected void OnEnable()
    {
        AssignEvents();
    }

    protected void OnDisable()
    {
        DisableEvents();
    }

    protected void Update()
    {
        DirectionalEventInput?.Invoke(_currentDirectionalInput);
    }

    private void DirectionalEventHandle(DirectionalInputEnum _directionalInput)
    {
        HandleDirectionalValue(_directionalInput);
    }

    private void NeutralEventHandle()
    {
        HandleDirectionalValue(DirectionalInputEnum.NEUTRAL);
    }

    private void HandleDirectionalValue(DirectionalInputEnum currentDirectionalInput) // Ok so we have a problem here....hmmm
    {
        _currentDirectionalInput = (int) currentDirectionalInput;
    }

    private void AssignEvents()
    {
        _rightEventTriggerButton.OnClickDown += DirectionalEventHandle; // Yeah I do not like that...
        _leftEventTriggerButton.OnClickDown += DirectionalEventHandle; // Yeah I do not like that...

        _rightEventTriggerButton.OnClickUp += NeutralEventHandle;
        _leftEventTriggerButton.OnClickUp += NeutralEventHandle;
    }

    private void DisableEvents()
    {
        _rightEventTriggerButton.OnClickDown -= DirectionalEventHandle; // Yeah I do not like that...
        _leftEventTriggerButton.OnClickDown -= DirectionalEventHandle; // Yeah I do not like that...

        _rightEventTriggerButton.OnClickUp -= NeutralEventHandle;
        _leftEventTriggerButton.OnClickUp -= NeutralEventHandle;
    }
}
