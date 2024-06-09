﻿﻿using Raylib_cs;

namespace AstraEngine.Canvas2D;

/// <summary>
/// An implementation of the <see cref="ICanvas2D"/> that is compatible with Raylib-cs.
/// </summary>
public sealed class RaylibCanvas2D : ICanvas2D
{
    /// <inheritdoc/>
    public void BeginDrawing() => Raylib.BeginDrawing();
    /// <inheritdoc/>
    public void Clear(Color backgroundColor) => Raylib.ClearBackground(backgroundColor.ToRayColor());
    /// <inheritdoc/>
    public void DrawPoly(Position2D origin, List<Position2D> vertices, Color color)
    {
        Raylib.DrawPoly(new System.Numerics.Vector2((int)origin.X, (int)origin.Y), 5, 30, 0, color.ToRayColor());
    }

    /// <inheritdoc/>
    public void DrawRectangle(Position2D topLeft, double width, double height, Color color)
    {
        Raylib.DrawRectangleRec(new Rectangle((float)topLeft.X, (float)topLeft.Y, (float)width, (float)height), color.ToRayColor());
    }
    /// <inheritdoc/>
    public void DrawText(Position2D location, string message, Color color)
    {
        Raylib.DrawText(message, (int)location.X, (int)location.Y, 12, color.ToRayColor());
    }
    /// <inheritdoc/>
    public void DrawPixel(Position2D location, Color color)
    {
        Raylib.DrawPixel((int)location.X, (int)location.Y, color.ToRayColor());
    }

    /// <inheritdoc/>
    public void EndDrawing() => Raylib.EndDrawing();
}