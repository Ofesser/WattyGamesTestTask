using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Objects movement. In larger project it could be useful to make this script parent, and describe
// the logic of concrete entities (different monsers for example) in children scripts,
// but in this projects it will be enough.

public class MovementEngine : MonoBehaviour {

    private float velocity;
    private Vector3 movementDirection;
    private Vector3 targetPosition;

    public void SetMovementDirection(Vector3 newDirection)
    {
        movementDirection = newDirection;
    }

    public void SetVelocity(float newVelocity)
    {
        velocity = newVelocity;
    }

    public void SetTargetPosition(Vector3 newTargetPosition)
    {
        targetPosition = newTargetPosition;
    }

    private void FixedUpdate()
    {
        PerformMovement();
        PerformRotation();
    }

    private void PerformMovement()
    {
        transform.position += movementDirection * velocity * Time.fixedDeltaTime;
    }

    private void PerformRotation()
    {
        transform.up = new Vector3(targetPosition.x,targetPosition.y,0f);
    }
}
