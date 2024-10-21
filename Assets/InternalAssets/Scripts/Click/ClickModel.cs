using System.Collections.Generic;
using UnityEngine;

public class ClickModel
{
    public List<Vector2> Points => _points;
    
    private List<Vector2> _points;

    public ClickModel()
    {
        _points = new List<Vector2>();
    }
}
