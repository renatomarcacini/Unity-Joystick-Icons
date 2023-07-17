using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private Button switchControlButton;

    private void Start()
    {
        switchControlButton.onClick.AddListener(delegate { OnClickSwitchControlButton(); });
        switchControlButton.GetComponentInChildren<Text>().text = JoystickIcon.Instance.GetTypeControlName();
    }

    private void OnClickSwitchControlButton()
    {
        JoystickIcon.Instance.NextTypeControl();
        switchControlButton.GetComponentInChildren<Text>().text = JoystickIcon.Instance.GetTypeControlName();
    }
}
