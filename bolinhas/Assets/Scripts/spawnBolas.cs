using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBolas : MonoBehaviour {

	public Transform	limiteCima, limiteBaixo, limiteEsquerda, limiteDireita;
	public GameObject	bola;
	private float		timer;
	public float		tempoSpawn;
	public int testegit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		
	}
}
