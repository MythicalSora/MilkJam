using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collection : MonoBehaviour
{
    [HideInInspector] public int counter=0;

// Start is called before the first frame update
    void Start()
    {
        ActivateChild();
    }

    public void ActivateChild()
    {
        transform.GetChild(counter).gameObject.SetActive(true);
    }

    public void DeactivateChild()
    {
        transform.GetChild(counter).gameObject.SetActive(false); 
    }
}
