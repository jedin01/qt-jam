extends CharacterBody2D

var speed = 200

func _physics_process(delta):
	# zera a velocidade para recalcular
	velocity = Vector2.ZERO
	
	if Input.is_action_pressed("A"):
		velocity.x += 1
	if Input.is_action_pressed("D"):
		velocity.x -= 1
	if Input.is_action_pressed("W"):
		velocity.y -= 1

	# normaliza para não andar mais rápido na diagonal
	velocity = velocity.normalized() * speed

	# move usando o CharacterBody2D (Godot 4)
	move_and_slide()
