using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player head script. Setting player parameters.
public class Player : MonoBehaviour {

    [SerializeField]
    private float playerMovementSpeed = 2f;

    private Weapon currentWeapon;

    public Weapon CurrentWeapon 
    {
        get { return currentWeapon; }
    }

    public float PlayerMovementSpeed
    {
        get { return playerMovementSpeed; }
    }

	void Start () {
        // Set default weapon for test.
        currentWeapon = GetComponent<Weapon>();
	}
}
