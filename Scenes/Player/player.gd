extends CharacterBody2D

@export var move_speed: float = 100
@onready var _animated_sprite = $AnimatedSprite2D

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	var move_vector: Vector2 = Input.get_vector("move_left", "move_right", "move_up", "move_down")
	
	# @sse https://docs.godotengine.org/en/4.4/tutorials/2d/2d_sprite_animation.html
	if Input.is_action_pressed("move_left"):
		_animated_sprite.play("move_left")
	elif Input.is_action_pressed("move_right"):
		_animated_sprite.play("move_right")
	elif Input.is_action_pressed("move_up"):
		_animated_sprite.play("move_up")
	elif Input.is_action_pressed("move_down"):
		_animated_sprite.play("move_down")
	else:
		_animated_sprite.stop()
		
	velocity = move_vector * move_speed
	move_and_slide()
	pass
