using UnityEngine;
using UnityEngine.UI;

public class MovementView : MonoBehaviour
{
    public Slider Slider => _slider;

    [SerializeField]
    private Slider _slider;

    public event System.Action<float> OnSpeedChanged;
    public event System.EventHandler OnFixedUpdate;

    private void Start()
    {
        _slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void FixedUpdate()
    {
        OnFixedUpdate?.Invoke(this, System.EventArgs.Empty);
    }

    private void HandleSliderValueChanged(float value)
    {
        OnSpeedChanged?.Invoke(value);
    }
}
