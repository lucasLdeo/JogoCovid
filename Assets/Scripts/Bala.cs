using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
	public float speed = 0.001f;
	public Rigidbody2D rb;	
	public int damage = 50;
	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}
	
	void OnTriggerEnter2D(Collider2D hitInfo){
		Inimigo player = hitInfo.GetComponent<Inimigo>();
		if (player != null){
			if (player.TakeDamage(damage)){ // se morreu 
				player.TakeDamage(damage);
			}else{				
				Movimento_Personagem mov = hitInfo.GetComponent<Movimento_Personagem>();											
				mov.verifica_morte = true;
				mov.verifica_Limite = true;
				mov.velocidade += 0.05f;
				player.health = 100;				
				mov.pontos += 1;
			}
		}
		Destroy(gameObject);		
	}
	
	
}
