using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Left_Mono : MonoBehaviour
{
    //private XRGrabInteractor interactor = null;

    // Start is called before the first frame update

    void Start()
    {
        //InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Controller & InputDeviceCharacteristics.TrackedDevice, _inputDevices);

        var inputDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevices(inputDevices);

        //InputDevices.GetDevices(devices);
        Debug.Log("Hey brother!!");
        Debug.Log(inputDevices);
        //Debug.Log(devices.Count);
        //foreach (var device in inputDevices)
        //{
        //    Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));
        //}
        //foreach (var item in devices) {
        //    Debug.Log(item.name);
        //}

        //interactor = GetComponent<XRRayInteractor>();

    }

    /*private void OnEnable()
    {
        interactor.onSelectEnter.AddListener(Hide);
        interactor.onSelectExit.AddListener(Show);
    }
    private void OnDisable()
    {
        interactor.onSelectEnter.RemoveListener(Hide);
        interactor.onSelectExit.RemoveListener(Show);
    }*/


    // Update is called once per frame
    void Update()
    {
        //LeftRayInteractn.hideControllerOnSelect = true;
        /*foreach (InputDevice inputDevice in _inputDevices)
        {
            if (inputDevice.characteristic.HasFlag(InputDeviceCharacteristic.Left))
            {
                // Left hand, grip button
                ProcessInputDeviceButton(inputDevice, InputHelpers.Button.Grip, ref _leftTriggerDown,
                () => // On Button Down
            {
                    Debug.Log("Left hand trigger down");
                // Your functionality
            },
                () => // On Button Up
            {
                    Debug.Log("Left hand trigger up");
                });
                // Repeat ProcessInputDeviceButton for other buttons
            }
            // Repeat for right hand
        }*/
    }

    /*private void ProcessInputDeviceButton(InputDevice inputDevice, InputHelpers.Button button, ref bool _wasPressedDownPreviousFrame, Action onButtonDown = null, Action onButtonUp = null, Action onButtonHeld = null)
    {
        if (inputDevice.IsPressed(button, out bool isPressed) && isPressed)
        {
            if (!_wasPressedDownPreviousFrame) // // this is button down
            {
                onButtonDown?.Invoke();
            }

            _wasPressedDownPreviousFrame = true;
            onButtonHeld?.Invoke();
        }
        else
        {
            if (_wasPressedDownPreviousFrame) // this is button up
            {
                onButtonUp?.Invoke();
            }

            _wasPressedDownPreviousFrame = false;
        }
    }*/


}
