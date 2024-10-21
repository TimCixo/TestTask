using UnityEngine;

[RequireComponent(typeof(MovementView))]
public class MovementManager : MonoBehaviour
{
    public MovementPresenter Presenter => _presenter;
    
    private MovementModel _model;
    private MovementView _view;
    private MovementPresenter _presenter;

    public void BootstrapStart()
    {
        _view = GetComponent<MovementView>();
        _model = new MovementModel(_view.Slider.value);
        _presenter = new MovementPresenter(_model, _view);
    }
}
