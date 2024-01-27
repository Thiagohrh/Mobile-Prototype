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

    public Action OnUpPressed;
    public Action OnAPressed;
    public Action OnBPressed;

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
        AssignDirectionalButtons();

        _upButton.onClick.AddListener(() => OnUpPressed?.Invoke());
        _aButton.onClick.AddListener(() => OnAPressed?.Invoke());
        _bButton.onClick.AddListener(() => OnBPressed?.Invoke());
    }

    private void RemoveListeners()
    {
        _upButton.onClick.RemoveAllListeners();
        _aButton.onClick.RemoveAllListeners();
        _bButton.onClick.RemoveAllListeners();
    }

    private void AssignDirectionalButtons() // Directionals will need another script.
    {
    }
}
