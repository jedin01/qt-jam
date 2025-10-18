using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export] public float Speed = 200f;

	// O código que executa a cada frame de física precisa estar dentro deste método
	public override void _PhysicsProcess(double delta)
	{
		GD.Print("rodando"); // ✅ aqui dentro funciona

		Vector2 velocity = Vector2.Zero;

		if (Input.IsKeyPressed((int)KeyList.W) || Input.IsActionPressed("ui_up"))
			velocity.Y -= 1;
		if (Input.IsKeyPressed((int)KeyList.S) || Input.IsActionPressed("ui_down"))
			velocity.Y += 1;
		if (Input.IsKeyPressed((int)KeyList.A) || Input.IsActionPressed("ui_left"))
			velocity.X -= 1;
		if (Input.IsKeyPressed((int)KeyList.D) || Input.IsActionPressed("ui_right"))
			velocity.X += 1;

		velocity = velocity.Normalized() * Speed;
		Velocity = velocity;

		MoveAndSlide();
	}
}
