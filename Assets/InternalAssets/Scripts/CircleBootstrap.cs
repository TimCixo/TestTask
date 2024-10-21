using UnityEngine;

[RequireComponent(typeof(MovementManager), typeof(ClickManager))]
public class CircleBootstrap : MonoBehaviour
{
    private ClickManager _clickManager;
    private MovementManager _movementManager;

    private void Start()
    {
        _clickManager = GetComponent<ClickManager>();
        _movementManager = GetComponent<MovementManager>();

        _clickManager.BootstrapStart();
        _movementManager.BootstrapStart();
    }
}