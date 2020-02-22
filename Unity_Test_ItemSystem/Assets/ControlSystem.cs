using UnityEngine;
using UnityEngine.UI;
using System;

public class ControlSystem : MonoBehaviour
{
    public KeyCode btn_jump;
    public KeyCode btn_attack;

    public KeyCode[] btn_selection;

    public Text textJump;

    public KeyCode press;

    private readonly Array keyCodes = Enum.GetValues(typeof(KeyCode));

    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode keyCode in keyCodes)
            {
                if (Input.GetKey(keyCode))
                {
                    Debug.Log("KeyCode down: " + keyCode);
                    btn_jump = keyCode;
                    break;
                }
            }
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(btn_jump))
        {
            print("跳躍");
        }

        if (Input.GetKeyDown(btn_attack))
        {
            print("攻擊");
        }

        print(Input.inputString);
    }
}
