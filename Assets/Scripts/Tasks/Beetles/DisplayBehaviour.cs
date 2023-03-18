using TMPro;
using UnityEngine;

public class DisplayBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counter;

    private int _number;

    // Update is called once per frame
    void Update()
    {
        counter.text = _number.ToString();
    }

    public void IncreaseCounter(int number)
    {
        if (_number < 100)
        {
            _number += number;
        }
    }
    
    public void DecreaseCounter(int number)
    {
        if (_number > -100)
        {
            _number -= number;
        }
    }
}
