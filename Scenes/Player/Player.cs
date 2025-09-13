using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export]
	private float moveSpeed = 100.0f;

	private AnimatedSprite2D animatedSprite;

	public override void _Ready()
	{
		animatedSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	public override void _PhysicsProcess(double delta)
    {
        Move();
        Animate();
    }

    private void Move()
    {
        /** https://docs.godotengine.org/de/4.x/tutorials/2d/2d_movement.html **/
        Vector2 inputDirection = Input.GetVector("move_left", "move_right", "move_up", "move_down") * moveSpeed;

        Velocity = inputDirection;
        MoveAndSlide();
    }

    private void Animate()
    {
        /** https://docs.godotengine.org/en/4.4/tutorials/2d/2d_sprite_animation.html **/
        if (Input.IsActionPressed("move_left"))
        {
            animatedSprite.Play("move_left");
        }
        else if (Input.IsActionPressed("move_right"))
        {
            animatedSprite.Play("move_right");
        }
        else if (Input.IsActionPressed("move_up"))
        {
            animatedSprite.Play("move_up");
        }
        else if (Input.IsActionPressed("move_down"))
        {
            animatedSprite.Play("move_down");
        }
        else
        {
            animatedSprite.Stop();
        }
    }
}
