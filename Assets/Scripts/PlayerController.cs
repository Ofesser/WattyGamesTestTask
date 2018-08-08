using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player controll
public class PlayerController : MonoBehaviour {

    private MovementEngine engine;
    private Player player;

	private void Start()
	{
        engine = GetComponent<MovementEngine>();
        player = GetComponent<Player>();
	}
	
	private void Update () 
    {
        engine.SetMovementDirection(CalculateMovementVector());
		engine.SetVelocity(player.PlayerMovementSpeed);
        engine.SetTargetPosition(CalculateTargetPosition());

        FireControll();
	}

    private Vector3 CalculateMovementVector()
    { 
        float horizontalVel = Input.GetAxisRaw("Horizontal");
        float verticalVel = Input.GetAxisRaw("Vertical");
        Vector3 movementVector = new Vector3(horizontalVel, verticalVel, 0f).normalized;
        return movementVector;
    }

    private Vector3 CalculateTargetPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		Vector3 resultVector = mousePosition - transform.position;
        return resultVector;
    }

    private void FireControll()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            player.CurrentWeapon.Shot();
        }
    }
}
