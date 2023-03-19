using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LampBehaviour : MonoBehaviour
{
    public Collection collection;

    public Canvas canvas;
    public DontDestroy dontDestroy;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -12 || transform.position.x >= 12)
        {
            collection.DeactivateChild();
            collection.counter = 1;
            dontDestroy.dialogCounter++;
        }
    }
}
