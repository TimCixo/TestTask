using UnityEngine;

public class ClickPresenter
{
    private ClickModel _model;
    private ClickView _view;

    public ClickPresenter(ClickModel clickModel, ClickView clickView)
    {
        _model = clickModel;
        _view = clickView;

        _view.OnClick += OnClick;
    }

    private void OnClick(Vector2 clickPosition)
    {
        _model.Points.Add(clickPosition);
    }

    public Vector2? GetFirstPoint()
    {
        if (_model.Points.Count > 0)
        {
            return _model.Points[0];
        }
        else
        {
            return null;
        }
    }

    public void RemovePoint(Vector2 point)
    {
        _model.Points.Remove(point);
    }
}