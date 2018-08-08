using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Bullet behaviour controller
public class Bullet : MonoBehaviour {

    private float speed;
    private float lifeTime = 3f;


	private void Start()
	{
        StartCoroutine(LifetimeObjectDestroy());
	}

	private void FixedUpdate () 
    {
        Move();
	}

    public void SetBulletParams(float newSpeed)
    {
        speed = newSpeed;
    }

    private void Move()
    { 
        transform.Translate(Vector3.up * speed * Time.fixedDeltaTime);
    }

    private IEnumerator LifetimeObjectDestroy()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
