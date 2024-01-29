using System;
using UnityEngine;
using UnityEngine.UI;

public class UiCharacterControls : MonoBehaviour
{
    [Header("Directional Buttons")]
    [SerializeField]
    private DirectionalButtonsBuffer _directionalButtonsBufferComponent;
    [SerializeField]
    private Button _upButton;
    [Header("Action Buttons")]
    [SerializeField]
    private Button _aButton;
    [SerializeField]
    private Button _bButton;

    public event Action OnUpPressed;
    public event Action OnAPressed;
    public event Action OnBPressed;
    public event Action<float> HorizontalAxisInput;

    protected void OnEnable()
    {
        AssignButtonsToFunctions();
    }

    protected void OnDisable()
    {
        RemoveListeners();
    }

    private void AssignButtonsToFunctions()
    {
        AssignDirectionalValue();
        _upButton.onClick.AddListener(() => OnUpPressed?.Invoke()); // Rework these. They're only activating on the button being released. Use the other thing.
        _aButton.onClick.AddListener(() => OnAPressed?.Invoke());
        _bButton.onClick.AddListener(() => OnBPressed?.Invoke());
    }

    private void RemoveListeners()
    {
        _upButton.onClick.RemoveAllListeners();
        _aButton.onClick.RemoveAllListeners();
        _bButton.onClick.RemoveAllListeners();
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
