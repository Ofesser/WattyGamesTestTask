using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Weapon script. In larger project it could be useful to make this script parent and describe
// the specific behaviour of different weapons in children scripts, but in this projects it will be enough.

public class Weapon : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private float bulletSpeed = 6f;
    [SerializeField]
    private float reloadTime = 0.5f;
    [SerializeField]
    private Transform firePoint;

    private float reloadTimer;

	private void Start()
	{
        reloadTimer = reloadTime;
	}

	private void Update()
	{
        CooldownControll();
	}

	public void Shot()
    {
        if (reloadTimer >= reloadTime)
        {
            GameObject newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
            newBullet.GetComponent<Bullet>().SetBulletParams(bulletSpeed);
            reloadTimer = 0f;
        }
    }

    public void CooldownControll()
    {
        if (reloadTimer < reloadTime)
        {
            reloadTimer += Time.deltaTime;
        }
    }
}
