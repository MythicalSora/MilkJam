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
    public Canvas canvas;
    void Update()
    {
        DialogCases();
        dialog.OnMouseOver(dialog.dialogBoxContainer);
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
                    dialog.dialogBox.color = Color.red;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                            "Error reported in Beetle insectarium.");
                    showDialogue = true;
                }
                break;
            case 2:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.black;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "Oh BUGger, it seems we already have a problem. Let’s check the cameras.");
                    showDialogue = true;
                }
                break;
            case 3:
                if (_currentScene.buildIndex == 3 &&  dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "It seems there is too much light near the food, I suggest moving the lampshade a few CENTIPETErs to cover it with shadow.");
                    showDialogue = true;
                }
                break;
            case 4:
                if (_currentScene.buildIndex == 1 &&  dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    collection.ActivateChild();
                }
                break;
            case 5:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.red;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "Error code: “Breach detected, 1 Beetle escaped.”");
                    showDialogue = true;
                }
                break;
            case 6:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.black;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "Okay, so they’ll FLEA if we move the lampshade, maybe try adjusting the brightness?");
                    showDialogue = true;
                }
                break;
            case 7:
                collection.ActivateChild();
                canvas.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 8:
                if (_currentScene.buildIndex == 1 && dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.red;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "!WARNING! Cable damage detected.");
                    showDialogue = true;
                }
                break;
            case 9:
                canvas.transform.GetChild(0).gameObject.SetActive(false);
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.black;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "Well, that mite become a problem. But we cANT do anything about that now.");
                    showDialogue = true;
                }
                break;
            case 10:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "You did it, finally the beetles can eat their fruit.");
                    showDialogue = true;
                }
                break;
            case 11:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.red;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "Error reported in Spider insectarium.");
                    showDialogue = true;
                }
                break;
            case 12:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.black;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "Amazing, another error. This already just TICK-s me off.");
                    showDialogue = true;
                }
                break;
            case 13:
                
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "I see the problem, too much humidity. We need to restart the ventilation system.");
                    showDialogue = true;
                }
                break;
            case 14:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "The code to restart it should be on the main screen. If you just enter the code to stop the ventilation, and after that reverse the process to turn it back on.");
                    showDialogue = true;
                }
                break;
            case 15:
                collection.ActivateChild();
                canvas.transform.GetChild(1).gameObject.SetActive(true);
                break;
            case 16:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.red;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "Breach detected, 3 Spiders escaped.");
                    showDialogue = true;
                }
                break;
            case 17:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.red;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "The USB Interface of [Peripheral Keyboard #7821] is experiencing slight internal interference, so inputs may be mismatched or may not function properly.");
                    showDialogue = true;
                }

                break;
            case 18:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.black;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "Well that doesn’t mean much good… I suggest you turn on the self-repair function. Again, go to the main screen, there LICE the code you need.");
                }
                break;
            case 19:
                if (dialog != null && dialog.dialogBoxContainer.activeSelf == false && showDialogue==false)
                {
                    dialog.dialogBox.color = Color.black;
                    dialog.ToggleDialog();
                    dialog.SetDialog("Art/MicIcon",
                        "You SNAILed it, your keyboard should be working normally now, with an emphasis on should.");
                }
                break;
               


        }
    }
}
