using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

	public int health = 100;
	public Rigidbody2D corpoPersonagem;
	public Vector2 direcao;

	public bool TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			return false;
		}
		return true;
	}

	
}
