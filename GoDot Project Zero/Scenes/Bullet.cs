using Godot;
using System;

public class Bullet : Area2D
{
    public static Vector2 dir = new Vector2();
    public const int SPEED = 300;
    
    public override void _Ready()
    {
        
    }

    public override void _PhysicsProcess(float delta){

        this.Translate(dir * SPEED * delta);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
