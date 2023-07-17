using UnityEngine;

public class Input_Sprite : Input_Base
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _iconKeyboard;
    [SerializeField] private Sprite _iconPlaystation;
    [SerializeField] private Sprite _iconXbox;
    [SerializeField] private Sprite _iconSwitch;

    public override void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        if (_spriteRenderer == null)
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        base.Start();
    }

    public override void UpdateIcon(TypeControl typeControl)
    {
        switch (typeControl)
        {
            case TypeControl.KEYBOARD:
                _spriteRenderer.sprite = _iconKeyboard;
                break;
            case TypeControl.PLAYSTATION:
                _spriteRenderer.sprite = _iconPlaystation;
                break;
            case TypeControl.XBOX:
                _spriteRenderer.sprite = _iconXbox;
                break;
            case TypeControl.SWITCH:
                _spriteRenderer.sprite = _iconSwitch;
                break;
        }
    }
}
