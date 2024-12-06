using Godot;
using System;

public partial class Main : Node2D
{
	int score = 0;
	Label scoreText;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		scoreText = GetNode<Label>($"CanvasLayer/Label");
	}
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void IncreaseScore()
	{
		score++;
		GD.Print("Increased Score");
		scoreText.SetText(score.ToString());
	}
	private void ResetScore()
	{
		score = 0;
		scoreText.SetText(score.ToString());
	}
	
	private void OnAreaEntered(Node2D otherNode)
	{
		BallMovement ball = otherNode as BallMovement;
		ball.ResetBall();
		ResetScore();
		GD.Print("EnteredArea");
	}
	
	
}
