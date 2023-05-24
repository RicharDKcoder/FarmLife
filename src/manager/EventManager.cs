using System;
using Microsoft.Xna.Framework;

namespace FarmLife;

public class EventManager
{
    private event EventHandler<Vector2> moveEvent;

    public void RegisterMovenEvent(EventHandler<Vector2> eventHandler)
    {
        this.moveEvent += eventHandler;
    }
    public void OnMoveEvent(Vector2 vector2)
    {
        moveEvent?.Invoke(this, vector2);
    }
}