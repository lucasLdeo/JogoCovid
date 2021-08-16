using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movimento_Personagem : MonoBehaviour {

	public Rigidbody2D corpoPersonagem;
	public float velocidade = 0.01f;
	public Vector2 direcao;
	public bool verifica_Limite = false;
	public bool verifica_morte = false;
	public int pontos = 0;
	public Text pontuacao;
	public Text GameOver;
	
	void Start () {
		GameOver.enabled = false;
	}
	void Update () {	
		
		pontuacao.text = "Pontuacao: "+pontos;
		if (corpoPersonagem.position.x >= 3) {
			verifica_Limite = true;
			direcao.x = -6;
			direcao.y = -1;
		}else{	
			direcao.x = 0.001f;	
			direcao.y = 0;
		}
	}
	
	void FixedUpdate(){
		Debug.Log(corpoPersonagem.position.x);
		if (!verifica_Limite){
			corpoPersonagem.MovePosition(corpoPersonagem.position + direcao * velocidade * Time.fixedDeltaTime );
		}else{
			if(verifica_morte){				
				direcao.x = -7;
				direcao.y = Random.Range(-1f, 2f);
				corpoPersonagem.MovePosition(direcao);
				verifica_morte = false;
				verifica_Limite = false;
			}else{
					GameOver.enabled = true;
					verifica_Limite = false;
			}
		}
	}
	
	
}
