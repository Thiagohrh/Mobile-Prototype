using UnityEngine;
using UnityEngine.UI;

public class UiCharacterControls : MonoBehaviour
{
    [Header("Directional Buttons")]
    [SerializeField]
    private Button _rightButton;
    [SerializeField]
    private Button _leftButton;
    [SerializeField]
    private Button _upButton;
    [Header("Action Buttons")]
    [SerializeField]
    private Button _aButton;
    [SerializeField]
    private Button _bButton;

    protected void Awake()
    {
        AssignButtonsToFunctions();
    }

    private void AssignButtonsToFunctions()
    {
        
    }
}
