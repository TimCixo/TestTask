using System;
using UnityEngine;

public class ClickView : MonoBehaviour
{
    public event Action<Vector2> OnClick;

    [SerializeField]
    private Camera _camera;

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Mouse0))
        {
            return;
        }

        Vector2 screenPosition = Input.mousePosition;
        Vector2 worldPosition = _camera.ScreenToWorldPoint(screenPosition);
        
        OnClick?.Invoke(worldPosition);
    }
}
