using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static Action<int> OnItemChoosed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            OnItemChoosed.Invoke(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            OnItemChoosed.Invoke(2);
        }
    }

}
