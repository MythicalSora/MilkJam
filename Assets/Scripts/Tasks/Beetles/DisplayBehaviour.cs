using TMPro;
using UnityEngine;

public class DisplayBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counter;
    
    public Collection collection;

    public Canvas canvas;
    public DontDestroy dontDestroy;

    private int _number = 100;

    // Update is called once per frame
    void Update()
    {
        counter.text = _number.ToString();
        if (_number <= 30)
        {
            collection.DeactivateChild();
            collection.counter = 2;
            dontDestroy.dialogCounter++;
        }
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
