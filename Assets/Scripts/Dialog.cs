using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public static Dialog Instance { get; private set; }

    [SerializeField] public Image avatar;
    [SerializeField] public TextMeshProUGUI dialogBox;
    [SerializeField] public GameObject dialogBoxContainer;
    public DontDestroy dontDestroy;
    public bool isActive;

    public void SetAvatar(string file)
    {
        if (Resources.Load<Sprite>(file) == null) return;

        var sprite = Resources.Load<Sprite>(file);
        Instance.avatar.sprite = sprite;
    }
    
    public void SetDialog(string file, string text)
    {
        SetAvatar(file);
        Instance.dialogBox.text = text;
    }

    public void ToggleDialog() => Instance.isActive = !Instance.isActive;

    void Awake()
    {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        }
    }

    private void FixedUpdate() => dialogBoxContainer.SetActive(Instance.isActive);

    public void OnMouseOver(GameObject dBox)
    {
        if (Input.GetMouseButtonDown(0) && dialogBoxContainer.activeSelf)
        {
            dontDestroy.dialogCounter++;
            ToggleDialog();
        }
    }
}