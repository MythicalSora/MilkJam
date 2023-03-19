using TMPro;
using UnityEngine;

public class DisplayBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counter;
    
    public Collection collection;

    public Canvas canvas;

    private int _number = 100;

    // Update is called once per frame
    void Update()
    {
        counter.text = _number.ToString();
        if (_number <= 30)
        {
            collection.DeactivateChild();
            collection.counter = 2;
            collection.ActivateChild();
            canvas.transform.GetChild(0).gameObject.SetActive(false);
            canvas.transform.GetChild(1).gameObject.SetActive(true);
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
