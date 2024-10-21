using System;
using UnityEngine;

public class MovementPresenter
{
    private MovementModel _model;
    private MovementView _view;
    private ClickPresenter _clickPresenter;
    private Rigidbody2D _rigidbody;

    public MovementPresenter(MovementModel model, MovementView view)
    {
        _model = model;
        _view = view;
        _rigidbody = _view.GetComponent<Rigidbody2D>();
        _clickPresenter = _view.GetComponent<ClickManager>().Presenter;

        _view.OnSpeedChanged += UpdateSpeed;
        _view.OnFixedUpdate +=  FixedUpdate;
    }

    private void FixedUpdate(object sender, EventArgs e)
    {
        Vector2? point = _clickPresenter.GetFirstPoint();

        if (point == null)
        {
            return;
        }

        MoveTo(point.Value);

        if (IsCloseEnoughToPoint(point.Value))
        {
            _clickPresenter.RemovePoint(point.Value);
        }
    }

    private void MoveTo(Vector2 point)
    {
        Vector2 currentPosition = _rigidbody.position;
        Vector2 direction = (point - currentPosition).normalized;
        Vector2 newPosition = currentPosition + direction  * _model.CurrentSpeed * Time.fixedDeltaTime;
        
        _rigidbody.MovePosition(newPosition);
    }

    private bool IsCloseEnoughToPoint(Vector2 point)
    {
        return Vector2.Distance(_view.transform.position, point) < 0.1f; // 0.1f - магічне число, що відповідає за різність точок
    }

    private void UpdateSpeed(float speed)
    {
        _model.CurrentSpeed = speed;
    }
}
