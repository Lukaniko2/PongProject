using Godot;
using System;

public partial class PlayerMovement : CharacterBody2D
{
	public const float Speed = 300.0f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;
		
		float moveY = Input.GetAxis("Up", "Down") * Speed * (float)delta;
		Translate(new Vector2(0, moveY));
		
		velocity.Y = Mathf.MoveToward(0, moveY, Speed);
		
		Velocity = velocity;
		MoveAndSlide();
	}
}
