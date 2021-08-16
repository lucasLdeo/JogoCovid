using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Seringa : MonoBehaviour {

	public Rigidbody2D corpoEnfermeira;	
	public float velocidade = 5;
	public Vector2 direcao;
	public bool verifica_Limite = false;
	

	void Start () {
		
	}

	void Update () {
		if (corpoEnfermeira.position.y >= 2 || corpoEnfermeira.position.y <= -2) {
			verifica_Limite = true;
			direcao.x = 4;
			direcao.y = -1.6f;
		}else{	
			direcao.x = 0;
			direcao.y = Input.GetAxisRaw("Vertical");
		}
	}
	
	void FixedUpdate(){			
		if (!verifica_Limite){
			corpoEnfermeira.MovePosition(corpoEnfermeira.position + direcao * velocidade * Time.fixedDeltaTime );
		}else{
			corpoEnfermeira.MovePosition(direcao);
			verifica_Limite = false;
		}
		
	}
}
