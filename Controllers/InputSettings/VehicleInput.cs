// GENERATED AUTOMATICALLY FROM 'Assets/OcsVehicle/Controllers/InputSettings/VehicleInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Ocs.Input
{
    public class @VehicleInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @VehicleInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""VehicleInput"",
    ""maps"": [
        {
            ""name"": ""CarDriver"",
            ""id"": ""3a787cf5-c818-453a-85dc-388ffe93e02d"",
            ""actions"": [
                {
                    ""name"": ""Accel"",
                    ""type"": ""Button"",
                    ""id"": ""4715564f-1219-4099-a076-7feed548e067"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""946e8425-5e46-4a77-84d8-66a059b424cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftUp"",
                    ""type"": ""Button"",
                    ""id"": ""e9ad70c9-ac4e-4e92-93f0-5886db46c686"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftDown"",
                    ""type"": ""Button"",
                    ""id"": ""4dc883c5-b116-4e83-80d3-439b96c8c10f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""7e58a3e1-5354-4644-a09f-b2a12f91e71b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""a617a83b-c52d-421b-b67c-17f317866af5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Light"",
                    ""type"": ""Button"",
                    ""id"": ""4d91bc7e-a82d-4cfc-beaf-1d214d09b69f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Joint0"",
                    ""type"": ""Button"",
                    ""id"": ""db9be559-5ed2-48a6-a5c2-9732ff38afd1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Joint1"",
                    ""type"": ""Button"",
                    ""id"": ""3b8f7116-04f8-4e17-8094-1f81e34b9de5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""12f71fe1-013a-4dde-ba9b-e2c0c0363529"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""571e0121-17dc-4cf5-b2df-9288e31ab6eb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13ead5e4-6813-4268-ad11-96c30ce279dc"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd17ec32-d1f2-4d8f-a66d-88e984ee2bb1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57a90925-d16a-4294-963d-2e922116b91d"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b32824a-8963-4f01-9f22-b300d83ad916"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a1ff0b3-e9da-4875-9d6e-9c24f011863b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3c5dd9a-2cca-482d-8d60-2d73e3ec5435"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e8b413f-8c33-479b-8ea6-de5cf5810131"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""1df4a0e6-360d-4e52-bee4-ba839ce6a066"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d01afcbe-8dfd-4c80-a479-c4a18aea6646"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9425977e-c23f-47df-b9f7-7d26465a3908"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8d8ae76c-0c1c-4778-a544-55cb8fb56f83"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a814bbc1-c14b-4cab-a8e9-f19fe1186758"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""42b2e801-51ac-40d4-9148-69e50f287321"",
                    ""path"": ""<XRController>/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d33c476-150d-441f-84ac-864225f69089"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28cffbed-b52e-4e42-8c59-570f67a2db80"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Light"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60db1cdf-24a1-4028-807a-b1f0110a710a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56246df5-b193-468b-b7e4-650e6776b119"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse;Touch"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79f97e59-a890-40ef-ac59-76603e5f09a7"",
                    ""path"": ""<Joystick>/{Hatswitch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d5ecc9ad-d5ef-47e1-af6c-15399e5369c7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joint0"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7279c3e9-680b-423e-8c34-6c3229cb6529"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joint0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c8537305-07f6-4c2e-a08d-f917d7b667d0"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Joint0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""170c7d74-465a-4af6-98f3-e22ffb729df9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joint1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fa44cf9b-9c33-4573-a925-02b6dc2f8f63"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joint1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a018fbfa-0599-4fdb-907d-038895d3c972"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Joint1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""BackhoeDriver"",
            ""id"": ""36d8e253-24b2-4dab-9733-1f93e0ecc605"",
            ""actions"": [
                {
                    ""name"": ""RightForward"",
                    ""type"": ""Button"",
                    ""id"": ""13d9c47c-66b0-49d5-a8e7-55b967b6e3d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightReverse"",
                    ""type"": ""Button"",
                    ""id"": ""f657710a-eee3-4bff-9640-ed14c47f220f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftForward"",
                    ""type"": ""Button"",
                    ""id"": ""32ee027c-cb1f-4b37-9b12-d8d3ef1d0679"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftReverse"",
                    ""type"": ""Button"",
                    ""id"": ""7ac3ea4c-2d22-4d96-8d4e-a023f488c2cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""Value"",
                    ""id"": ""a6a721bf-9eaf-4ee1-b2d1-f6018ddeb107"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStick"",
                    ""type"": ""Value"",
                    ""id"": ""7a9a9ee0-6675-4436-a8f1-3c6e60ffd98c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Light"",
                    ""type"": ""Button"",
                    ""id"": ""07717c8a-bdf5-424e-b23e-7eaa36899f43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a7b57970-ecd0-4209-8750-79730c9d1174"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RightForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85080ecd-23a4-4ee5-b801-abfed8430998"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LeftForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e90a956-6dba-45a1-87f9-eed4ca3d4f9e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LeftReverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58717f3d-8993-46c3-9896-69cce5cdcc5d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""d5dd529b-d2c7-4a47-8aa4-3d12b934fc42"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b9b51c16-f292-478d-bc5f-e04f04c64b58"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""09a2d6db-ae38-4856-98bd-9bdddfcfad43"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e05d7377-40a0-46b9-8419-9b2a37acf46c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""46501df0-d0e4-46a9-91fc-fd7d75665777"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""83b3803e-4771-49ff-9517-f385c82656ee"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""611797a9-e030-458f-bd9d-d78f403a967a"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Light"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d8108c7-6255-48fb-a147-c958e824ffee"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""IJKL"",
                    ""id"": ""3df45a39-eff7-4bac-9ca9-014ffd2f468c"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1bcfdc51-275e-4eb5-822c-46118bfd32fc"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d18d2e22-eaaa-4be6-b237-c036bbe476d9"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""276ed16f-c268-4819-a87f-e0a0feec1b06"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""76b3d9cf-eba9-4cec-908a-7d54cad8ea34"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3c5578a9-6938-430b-90de-4e6f38642993"",
                    ""path"": ""<Joystick>/{Hatswitch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5afb5b28-e869-46cb-bd44-237caa64a2c1"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RightReverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // CarDriver
            m_CarDriver = asset.FindActionMap("CarDriver", throwIfNotFound: true);
            m_CarDriver_Accel = m_CarDriver.FindAction("Accel", throwIfNotFound: true);
            m_CarDriver_Brake = m_CarDriver.FindAction("Brake", throwIfNotFound: true);
            m_CarDriver_ShiftUp = m_CarDriver.FindAction("ShiftUp", throwIfNotFound: true);
            m_CarDriver_ShiftDown = m_CarDriver.FindAction("ShiftDown", throwIfNotFound: true);
            m_CarDriver_Steering = m_CarDriver.FindAction("Steering", throwIfNotFound: true);
            m_CarDriver_Look = m_CarDriver.FindAction("Look", throwIfNotFound: true);
            m_CarDriver_Light = m_CarDriver.FindAction("Light", throwIfNotFound: true);
            m_CarDriver_Joint0 = m_CarDriver.FindAction("Joint0", throwIfNotFound: true);
            m_CarDriver_Joint1 = m_CarDriver.FindAction("Joint1", throwIfNotFound: true);
            // BackhoeDriver
            m_BackhoeDriver = asset.FindActionMap("BackhoeDriver", throwIfNotFound: true);
            m_BackhoeDriver_RightForward = m_BackhoeDriver.FindAction("RightForward", throwIfNotFound: true);
            m_BackhoeDriver_RightReverse = m_BackhoeDriver.FindAction("RightReverse", throwIfNotFound: true);
            m_BackhoeDriver_LeftForward = m_BackhoeDriver.FindAction("LeftForward", throwIfNotFound: true);
            m_BackhoeDriver_LeftReverse = m_BackhoeDriver.FindAction("LeftReverse", throwIfNotFound: true);
            m_BackhoeDriver_LeftStick = m_BackhoeDriver.FindAction("LeftStick", throwIfNotFound: true);
            m_BackhoeDriver_RightStick = m_BackhoeDriver.FindAction("RightStick", throwIfNotFound: true);
            m_BackhoeDriver_Light = m_BackhoeDriver.FindAction("Light", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // CarDriver
        private readonly InputActionMap m_CarDriver;
        private ICarDriverActions m_CarDriverActionsCallbackInterface;
        private readonly InputAction m_CarDriver_Accel;
        private readonly InputAction m_CarDriver_Brake;
        private readonly InputAction m_CarDriver_ShiftUp;
        private readonly InputAction m_CarDriver_ShiftDown;
        private readonly InputAction m_CarDriver_Steering;
        private readonly InputAction m_CarDriver_Look;
        private readonly InputAction m_CarDriver_Light;
        private readonly InputAction m_CarDriver_Joint0;
        private readonly InputAction m_CarDriver_Joint1;
        public struct CarDriverActions
        {
            private @VehicleInput m_Wrapper;
            public CarDriverActions(@VehicleInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Accel => m_Wrapper.m_CarDriver_Accel;
            public InputAction @Brake => m_Wrapper.m_CarDriver_Brake;
            public InputAction @ShiftUp => m_Wrapper.m_CarDriver_ShiftUp;
            public InputAction @ShiftDown => m_Wrapper.m_CarDriver_ShiftDown;
            public InputAction @Steering => m_Wrapper.m_CarDriver_Steering;
            public InputAction @Look => m_Wrapper.m_CarDriver_Look;
            public InputAction @Light => m_Wrapper.m_CarDriver_Light;
            public InputAction @Joint0 => m_Wrapper.m_CarDriver_Joint0;
            public InputAction @Joint1 => m_Wrapper.m_CarDriver_Joint1;
            public InputActionMap Get() { return m_Wrapper.m_CarDriver; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CarDriverActions set) { return set.Get(); }
            public void SetCallbacks(ICarDriverActions instance)
            {
                if (m_Wrapper.m_CarDriverActionsCallbackInterface != null)
                {
                    @Accel.started -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnAccel;
                    @Accel.performed -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnAccel;
                    @Accel.canceled -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnAccel;
                    @Brake.started -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnBrake;
                    @Brake.performed -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnBrake;
                    @Brake.canceled -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnBrake;
                    @ShiftUp.started -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnShiftUp;
                    @ShiftUp.performed -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnShiftUp;
                    @ShiftUp.canceled -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnShiftUp;
                    @ShiftDown.started -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnShiftDown;
                    @ShiftDown.performed -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnShiftDown;
                    @ShiftDown.canceled -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnShiftDown;
                    @Steering.started -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnSteering;
                    @Steering.performed -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnSteering;
                    @Steering.canceled -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnSteering;
                    @Look.started -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnLook;
                    @Light.started -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnLight;
                    @Light.performed -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnLight;
                    @Light.canceled -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnLight;
                    @Joint0.started -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnJoint0;
                    @Joint0.performed -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnJoint0;
                    @Joint0.canceled -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnJoint0;
                    @Joint1.started -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnJoint1;
                    @Joint1.performed -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnJoint1;
                    @Joint1.canceled -= m_Wrapper.m_CarDriverActionsCallbackInterface.OnJoint1;
                }
                m_Wrapper.m_CarDriverActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Accel.started += instance.OnAccel;
                    @Accel.performed += instance.OnAccel;
                    @Accel.canceled += instance.OnAccel;
                    @Brake.started += instance.OnBrake;
                    @Brake.performed += instance.OnBrake;
                    @Brake.canceled += instance.OnBrake;
                    @ShiftUp.started += instance.OnShiftUp;
                    @ShiftUp.performed += instance.OnShiftUp;
                    @ShiftUp.canceled += instance.OnShiftUp;
                    @ShiftDown.started += instance.OnShiftDown;
                    @ShiftDown.performed += instance.OnShiftDown;
                    @ShiftDown.canceled += instance.OnShiftDown;
                    @Steering.started += instance.OnSteering;
                    @Steering.performed += instance.OnSteering;
                    @Steering.canceled += instance.OnSteering;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Light.started += instance.OnLight;
                    @Light.performed += instance.OnLight;
                    @Light.canceled += instance.OnLight;
                    @Joint0.started += instance.OnJoint0;
                    @Joint0.performed += instance.OnJoint0;
                    @Joint0.canceled += instance.OnJoint0;
                    @Joint1.started += instance.OnJoint1;
                    @Joint1.performed += instance.OnJoint1;
                    @Joint1.canceled += instance.OnJoint1;
                }
            }
        }
        public CarDriverActions @CarDriver => new CarDriverActions(this);

        // BackhoeDriver
        private readonly InputActionMap m_BackhoeDriver;
        private IBackhoeDriverActions m_BackhoeDriverActionsCallbackInterface;
        private readonly InputAction m_BackhoeDriver_RightForward;
        private readonly InputAction m_BackhoeDriver_RightReverse;
        private readonly InputAction m_BackhoeDriver_LeftForward;
        private readonly InputAction m_BackhoeDriver_LeftReverse;
        private readonly InputAction m_BackhoeDriver_LeftStick;
        private readonly InputAction m_BackhoeDriver_RightStick;
        private readonly InputAction m_BackhoeDriver_Light;
        public struct BackhoeDriverActions
        {
            private @VehicleInput m_Wrapper;
            public BackhoeDriverActions(@VehicleInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @RightForward => m_Wrapper.m_BackhoeDriver_RightForward;
            public InputAction @RightReverse => m_Wrapper.m_BackhoeDriver_RightReverse;
            public InputAction @LeftForward => m_Wrapper.m_BackhoeDriver_LeftForward;
            public InputAction @LeftReverse => m_Wrapper.m_BackhoeDriver_LeftReverse;
            public InputAction @LeftStick => m_Wrapper.m_BackhoeDriver_LeftStick;
            public InputAction @RightStick => m_Wrapper.m_BackhoeDriver_RightStick;
            public InputAction @Light => m_Wrapper.m_BackhoeDriver_Light;
            public InputActionMap Get() { return m_Wrapper.m_BackhoeDriver; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BackhoeDriverActions set) { return set.Get(); }
            public void SetCallbacks(IBackhoeDriverActions instance)
            {
                if (m_Wrapper.m_BackhoeDriverActionsCallbackInterface != null)
                {
                    @RightForward.started -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnRightForward;
                    @RightForward.performed -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnRightForward;
                    @RightForward.canceled -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnRightForward;
                    @RightReverse.started -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnRightReverse;
                    @RightReverse.performed -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnRightReverse;
                    @RightReverse.canceled -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnRightReverse;
                    @LeftForward.started -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLeftForward;
                    @LeftForward.performed -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLeftForward;
                    @LeftForward.canceled -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLeftForward;
                    @LeftReverse.started -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLeftReverse;
                    @LeftReverse.performed -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLeftReverse;
                    @LeftReverse.canceled -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLeftReverse;
                    @LeftStick.started -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLeftStick;
                    @LeftStick.performed -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLeftStick;
                    @LeftStick.canceled -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLeftStick;
                    @RightStick.started -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnRightStick;
                    @RightStick.performed -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnRightStick;
                    @RightStick.canceled -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnRightStick;
                    @Light.started -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLight;
                    @Light.performed -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLight;
                    @Light.canceled -= m_Wrapper.m_BackhoeDriverActionsCallbackInterface.OnLight;
                }
                m_Wrapper.m_BackhoeDriverActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @RightForward.started += instance.OnRightForward;
                    @RightForward.performed += instance.OnRightForward;
                    @RightForward.canceled += instance.OnRightForward;
                    @RightReverse.started += instance.OnRightReverse;
                    @RightReverse.performed += instance.OnRightReverse;
                    @RightReverse.canceled += instance.OnRightReverse;
                    @LeftForward.started += instance.OnLeftForward;
                    @LeftForward.performed += instance.OnLeftForward;
                    @LeftForward.canceled += instance.OnLeftForward;
                    @LeftReverse.started += instance.OnLeftReverse;
                    @LeftReverse.performed += instance.OnLeftReverse;
                    @LeftReverse.canceled += instance.OnLeftReverse;
                    @LeftStick.started += instance.OnLeftStick;
                    @LeftStick.performed += instance.OnLeftStick;
                    @LeftStick.canceled += instance.OnLeftStick;
                    @RightStick.started += instance.OnRightStick;
                    @RightStick.performed += instance.OnRightStick;
                    @RightStick.canceled += instance.OnRightStick;
                    @Light.started += instance.OnLight;
                    @Light.performed += instance.OnLight;
                    @Light.canceled += instance.OnLight;
                }
            }
        }
        public BackhoeDriverActions @BackhoeDriver => new BackhoeDriverActions(this);
        public interface ICarDriverActions
        {
            void OnAccel(InputAction.CallbackContext context);
            void OnBrake(InputAction.CallbackContext context);
            void OnShiftUp(InputAction.CallbackContext context);
            void OnShiftDown(InputAction.CallbackContext context);
            void OnSteering(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnLight(InputAction.CallbackContext context);
            void OnJoint0(InputAction.CallbackContext context);
            void OnJoint1(InputAction.CallbackContext context);
        }
        public interface IBackhoeDriverActions
        {
            void OnRightForward(InputAction.CallbackContext context);
            void OnRightReverse(InputAction.CallbackContext context);
            void OnLeftForward(InputAction.CallbackContext context);
            void OnLeftReverse(InputAction.CallbackContext context);
            void OnLeftStick(InputAction.CallbackContext context);
            void OnRightStick(InputAction.CallbackContext context);
            void OnLight(InputAction.CallbackContext context);
        }
    }
}
