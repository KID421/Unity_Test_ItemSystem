using UnityEngine;

public class MouseTarget : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        Follow();
    }

    private void Follow()
    {
        GetComponent<RectTransform>().position = Input.mousePosition;
    }
}
