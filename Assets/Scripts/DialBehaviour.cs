using UnityEngine;

public class DialBehaviour : MonoBehaviour
{
    [SerializeField] private DisplayBehaviour dpBehaviour;
    private float _lastMousePosition;

    // Start is called before the first frame update
    void Start()
    {
        _lastMousePosition = Input.GetAxisRaw("Mouse X");
    }

    private void OnMouseDrag()
    {
        float pos = Input.GetAxisRaw("Mouse X");

        if (pos > _lastMousePosition)
        {
            dpBehaviour.IncreaseCounter(1);
        } else if (pos < _lastMousePosition)
        {
            dpBehaviour.DecreaseCounter(1);
        }
        
        transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, -(pos*1.5f)));
    }
}
