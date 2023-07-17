using UnityEngine;

public class Input_Base : MonoBehaviour
{
    private void OnEnable() => JoystickIcon.OnSwitchTypeControl += SwitchControl;
    private void OnDisable() => JoystickIcon.OnSwitchTypeControl -= SwitchControl;

    public virtual void Start() => UpdateIcon(JoystickIcon.Instance.typeControl);

    public virtual void SwitchControl(TypeControl typeControl) => UpdateIcon(typeControl);

    public virtual void UpdateIcon(TypeControl typeControl){}
}
