using System;
using UnityEngine;

public class MainCharacterUiButtonLink : MonoBehaviour
{
    [SerializeField] private Transform _mainCharacterTransform;
    private IControlableCharacter _mainCharacterInputManager;
    private UiCharacterControls _myUiCharacterControls;

    private void Start()
    {
        if (_mainCharacterInputManager != null)
        {
            LinkUiControlsToCharacter();
        }
    }

    private void OnEnable()
    {
        _myUiCharacterControls = transform.GetComponent<UiCharacterControls>();
        _mainCharacterInputManager = _mainCharacterTransform.GetComponent<IControlableCharacter>();
    }

    private void OnDisable()
    {
        if (_mainCharacterInputManager != null)
        {
            UnlinkUiControlsToCharacter();
        }
    }

    private void LinkUiControlsToCharacter()
    {
        _myUiCharacterControls.OnUpPressed += _mainCharacterInputManager.Jump;
        _myUiCharacterControls.OnAPressed += _mainCharacterInputManager.Shoot;
        _myUiCharacterControls.OnBPressed += _mainCharacterInputManager.Strike;
        _myUiCharacterControls.HorizontalAxisInput += _mainCharacterInputManager.Move;
    }

    private void UnlinkUiControlsToCharacter()
    {
        _myUiCharacterControls.OnUpPressed -= _mainCharacterInputManager.Jump;
        _myUiCharacterControls.OnAPressed -= _mainCharacterInputManager.Shoot;
        _myUiCharacterControls.OnBPressed -= _mainCharacterInputManager.Strike;
        _myUiCharacterControls.HorizontalAxisInput -= _mainCharacterInputManager.Move;
    }
}
