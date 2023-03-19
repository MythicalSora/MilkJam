using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LampBehaviour : MonoBehaviour
{
    public Collection collection;

    public Canvas canvas;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -12 || transform.position.x >= 12)
        {
            collection.DeactivateChild();
            collection.counter = 1;
            collection.ActivateChild();
            canvas.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
