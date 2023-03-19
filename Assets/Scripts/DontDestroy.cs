using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class DontDestroy : MonoBehaviour
{
    [SerializeField] private Dialog dialog;
    public int dialogCounter = 0;
    public bool showDialogue = false;
    private Scene _currentScene;
    public Collection collection;
    void Update()
    {
        Debug.Log(dialogCounter);
        DialogCases();
        dialog.OnMouseOver(dialog.dialogBoxContainer);
        if (dialogCounter == 1 && dialog.dialogBoxContainer.activeSelf == false)
        {
            showDialogue = false;
        }

        _currentScene = SceneManager.GetActiveScene();
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(1);
    }

    void DialogCases()
    {
        switch (dialogCounter)
        {
            case 0:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "Good morning, I’m Mrs. Ingme. I will be assisting you today if you encounter anything unusual.");
                    showDialogue = true;
                    
                }
                break;
            case 1:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "Oh BUGger, it seems we already have a problem. Let’s check the cameras.");
                    showDialogue = true;
                }
                break;
            case 2:
                if (_currentScene.buildIndex == 3 &&  dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "It seems there is too much light near the food, I suggest moving the lampshade a few CENTIPETErs to cover it with shadow.");
                    showDialogue = true;
                }
                break;
            case 3:
                break;
                
                
        }
    }
}
