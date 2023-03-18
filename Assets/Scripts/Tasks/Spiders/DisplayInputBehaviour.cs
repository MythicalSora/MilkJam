using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class DisplayInputBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI display;
    [SerializeField] private int cypherKey;
    [SerializeField] private int adminPassword;
    [SerializeField] private int fanKey;
    private int _reverseFanKey;
    private int _adminKey;
    private string _input = string.Empty;
    private int[] _numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

    private KeyCode[] _keyCodes = {
        KeyCode.Alpha0,
        KeyCode.Alpha1,
        KeyCode.Alpha2,
        KeyCode.Alpha3,
        KeyCode.Alpha4,
        KeyCode.Alpha5,
        KeyCode.Alpha6,
        KeyCode.Alpha7,
        KeyCode.Alpha8,
        KeyCode.Alpha9,
    };
    
    private int Swap(int code)
    {
        return code switch
        {
            0 => 7,
            1 => 8,
            2 => 9,
            _ => code - cypherKey
        };
    }

    private static int Reverse(int key)
    {
        char[] rawKey = key.ToString().ToCharArray();
        rawKey.Reverse();
        return int.Parse(rawKey);
    }

    void Start()
    {
        _reverseFanKey = Reverse(fanKey);
        _adminKey = Swap(adminPassword);
    }

    void Update()
    {
        for (int i = 0; i < _keyCodes.Length; i++)
        {
            if (Input.GetKeyUp(_keyCodes[i]))
            {
                if (_input.Length <= 4 ) _input += Swap(i);
            }
        }

        if (Input.GetKeyUp("backspace"))
        {
            display.color = Color.black;
            if (_input.Length != 0) _input = _input.Remove(_input.Length - 1);
        }

        display.text = _input;

        if (Input.GetKeyUp("return"))
        {
            if (int.Parse(_input) == fanKey) display.color = Color.green;
            else display.color = Color.red;
        }
    }
}
