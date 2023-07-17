using UnityEngine;
using UnityEngine.UI;

public class Input_UI : Input_Base
{
    [SerializeField] private Image _imageIcon;
    [SerializeField] private Sprite _iconKeyboard;
    [SerializeField] private Sprite _iconPlaystation;
    [SerializeField] private Sprite _iconXbox;
    [SerializeField] private Sprite _iconSwitch;

    public override void Start()
    {
        _imageIcon = GetComponent<Image>();
        if (_imageIcon == null)
            _imageIcon = GetComponentInChildren<Image>();
        base.Start();
    }

    public override void UpdateIcon(TypeControl typeControl)
    {
        switch (typeControl)
        {
            case TypeControl.KEYBOARD:
                _imageIcon.sprite = _iconKeyboard;
                break;
            case TypeControl.PLAYSTATION:
                _imageIcon.sprite = _iconPlaystation;
                break;
            case TypeControl.XBOX:
                _imageIcon.sprite = _iconXbox;
                break;
            case TypeControl.SWITCH:
                _imageIcon.sprite = _iconSwitch;
                break;
        }
    }
}
