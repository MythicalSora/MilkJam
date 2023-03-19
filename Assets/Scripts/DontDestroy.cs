using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    [SerializeField] private Dialog dialog;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            if (dialog != null) dialog.ToggleDialog();
            dialog.SetDialog("Avatars/kweh", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum scelerisque nunc tincidunt fermentum placerat.\n Pellentesque vitae massa euismod, varius sem vel, tincidunt odio. In efficitur augue in luctus rutrum. Morbi eu varius turpis.\n Integer vel orci sit amet sem viverra. ");
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
