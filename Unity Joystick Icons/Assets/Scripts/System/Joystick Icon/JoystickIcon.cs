using System;
using UnityEngine;

public class JoystickIcon : MonoBehaviour
{
    public static JoystickIcon Instance;

    public TypeControl typeControl;
    private int typeControlPreference = 0;

    public static event Action<TypeControl> OnSwitchTypeControl;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(Instance);
        DontDestroyOnLoad(gameObject);  
        typeControlPreference = PlayerPrefs.GetInt("control_preference", 0);
        typeControl = (TypeControl)typeControlPreference;
    }

    public void SetControlPreference(TypeControl control)
    {
        typeControl = control;
        typeControlPreference = (int)control;
        PlayerPrefs.SetInt("control_preference", typeControlPreference);
        OnSwitchTypeControl?.Invoke(typeControl);
    }

    public void NextTypeControl()
    {
        typeControlPreference++;
        if(typeControlPreference > Enum.GetNames(typeof(TypeControl)).Length - 1)
            typeControlPreference = 0;

        SetControlPreference((TypeControl)typeControlPreference);
    }

    public string GetTypeControlName() => Enum.GetNames(typeof(TypeControl))[typeControlPreference].ToString();
}

public enum TypeControl
{
    KEYBOARD = 0,
    PLAYSTATION,
    XBOX,
    SWITCH
}
