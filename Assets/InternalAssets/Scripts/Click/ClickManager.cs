using UnityEngine;

[RequireComponent(typeof(ClickView))]
public class ClickManager : MonoBehaviour
{
    public ClickPresenter Presenter => _presenter;

    private ClickModel _model;
    private ClickView _view;
    private ClickPresenter _presenter;

    public void BootstrapStart()
    {
        _model = new ClickModel();
        _view = GetComponent<ClickView>();
        _presenter = new ClickPresenter(_model, _view);
    }
}
