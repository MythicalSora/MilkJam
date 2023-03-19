using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DisplayInputBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI display;
    [SerializeField] private int cypherKey;
    [SerializeField] private int adminPassword;
    [SerializeField] private int fanKey;
    private int _reverseFanKey;
    private string _input = string.Empty;
    private int[] _numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
    private int _code = 0;
    
    public Collection collection;

    public Canvas canvas;
    
    

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

    // private static int Reverse(int key)
    // {
    //     char[] rawKey = key.ToString().ToCharArray();
    //     rawKey.Reverse();
    //     return int.Parse(rawKey);
    // }

    private int Reverse(int number)
    {
        int reverse = 0;
        while (number > 0)
        {
            int remainder = number % 10;
            reverse = (reverse * 10) + remainder;
            number = number / 10;
        }

        return reverse;
    }
    

    void Start()
    {
        _reverseFanKey = Reverse(fanKey);
        Debug.Log(_reverseFanKey);
    }

    void Update()
    {
        switch (_code)
        {
            case 0:
                NormalFanKeyType();
                break;
            case 1:
                ReverseFanKeyType();
                break;
            case 2:
                AdminCypherKeyType();
                break;
            case 3:
                collection.DeactivateChild();
                collection.counter = 3;
                collection.ActivateChild();
                canvas.transform.GetChild(1).gameObject.SetActive(false);
                break;
        }
        
        if (Input.GetKeyUp("backspace"))
        {
            display.color = Color.black;
            if (_input.Length != 0) _input = _input.Remove(_input.Length - 1);
        }

        display.text = _input;
    }

    void NormalFanKeyType()
    {
        for (int i = 0; i < _keyCodes.Length; i++)
        {
            if (Input.GetKeyUp(_keyCodes[i]))
            {
                if (_input.Length <= 4 ) _input += i;
            }
        }
        
        if (Input.GetKeyUp("return"))
        {
            if (int.Parse(_input) == fanKey)
            {
                display.color = Color.green;
                _code = 1;
                display.text = null;
                Debug.Log(_code);
            }
            else display.color = Color.red;
        }
    }

    void ReverseFanKeyType()
    {
        for (int i = 0; i < _keyCodes.Length; i++)
        {
            if (Input.GetKeyUp(_keyCodes[i]))
            {
                if (_input.Length <= 4 ) _input += i;
            }
        }
        
        if (Input.GetKeyUp("return"))
        {
            if (int.Parse(_input) == _reverseFanKey)
            {
                display.color = Color.green;
                _code = 2;
                display.text = null;
            }
            else display.color = Color.red;
        }
    }

    void AdminCypherKeyType()
    {
        for (int i = 0; i < _keyCodes.Length; i++)
        {
            if (Input.GetKeyUp(_keyCodes[i]))
            {
                if (_input.Length <= 4 ) _input += Swap(i);
            }
        }
        
        if (Input.GetKeyUp("return"))
        {
            if (int.Parse(_input) == adminPassword)
            {
                display.color = Color.green;
                _code = 3;
            }
            else display.color = Color.red;
        }
    }
}
