﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
	[SerializeField] GameObject shipPos;
   // private ShipScript ship; // Bullet's target: whatever gameObject with ShipScript attached
	public float bulletSpd; // Moving speed of bullet
    public Vector3 moveDirection;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		shipPos = GameObject.FindGameObjectWithTag("Ship");
		// ship = GameObject.FindObjectOfType<ShipScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * bulletSpd, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ship")
        {
            other.gameObject.GetComponent<BoatCombat>().TakeDamage(5, gameObject);
            Destroy(gameObject);
        }
    }
}