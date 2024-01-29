using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiCharacterControls : MonoBehaviour
{
    [Header("Directional Buttons")]
    [SerializeField]
    private DirectionalButtonsBuffer _directionalButtonsBufferComponent;
    [Header("Action Buttons")]
    [SerializeField]
    private EventTriggerButton _upButton;
    [SerializeField]
    private EventTriggerButton _aButton;
    [SerializeField]
    private EventTriggerButton _bButton;

    public event Action OnUpPressed;
    public event Action OnAPressed;
    public event Action OnBPressed;
    public event Action<float> HorizontalAxisInput;

    protected void OnEnable()
    {
        AssignButtonListeners();
    }

    protected void OnDisable()
    {
        RemoveListeners();
    }

    private void AssignButtonListeners()
    {
        AssignDirectionalValue();
        _upButton.OnClickDown += OnUpButtonClick;
        _aButton.OnClickDown += OnAButtonClick;
        _bButton.OnClickDown += OnBButtonClick;
    }

    private void OnUpButtonClick()
    {
        OnUpPressed?.Invoke();
    }

    private void OnAButtonClick()
    {
        OnAPressed?.Invoke();
    }

    private void OnBButtonClick()
    {
        OnBPressed?.Invoke();
    }

    private void RemoveListeners()
    {
        _upButton.OnClickDown -= OnUpButtonClick;
        _aButton.OnClickDown -= OnAButtonClick;
        _bButton.OnClickDown -= OnBButtonClick;
        _directionalButtonsBufferComponent.DirectionalEventInput -= DirectionalInput;
    }

    private void AssignDirectionalValue()
    {
        _directionalButtonsBufferComponent.DirectionalEventInput += DirectionalInput;
    }

    private void DirectionalInput(float direction)
    {
        HorizontalAxisInput?.Invoke(direction);
    }
}
