using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {
	public static int pontos = 0;
	public Text pontuacao;
	// Use this for initialization
	void Start () {
		pontuacao = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(pontos);
		pontuacao.text = "Pontuacão:"+pontos;
	}
}
