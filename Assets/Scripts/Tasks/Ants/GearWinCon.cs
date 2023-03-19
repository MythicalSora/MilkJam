using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SocialPlatforms.GameCenter;

public class GearWinCon : MonoBehaviour
{
    public string gearName;
    public GearBehaviour gearBehaviour;
    private bool _gearSnap = false;
    private void Update()
    {
        Collider2D targetObject = Physics2D.OverlapPoint(transform.position);
        if (targetObject.name == gearName && _gearSnap == false)
        {
            gearBehaviour.puzzleCounter += 1;
            _gearSnap = true;
        }
    }
}
