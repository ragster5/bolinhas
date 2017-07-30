using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour {

	private SpriteRenderer figura;
	private int	codigoCor;


	// Use this for initialization
	void Start () {
		figura = GetComponent<SpriteRenderer> ();
		figura.color = sorteioCor ();
		int i;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setCodigoCor(int codigo){
		this.codigoCor = codigo;

	}
	private Color sorteioCor(){
		int sorteio = Random.Range (1, 11);
		switch (sorteio) {
		case 1:
			setCodigoCor (1);
			return Color.black;
		case 2:
			setCodigoCor (2);
			return Color.blue;
		case 3:
			setCodigoCor (3);
			return Color.cyan;
		case 4:
			setCodigoCor (4);
			return Color.gray;
		case 5:
			setCodigoCor (5);
			return Color.green;
		case 6:
			setCodigoCor (6);
			return Color.grey;
		case 7:
			setCodigoCor (7);
			return Color.magenta;
		case 8:
			setCodigoCor (8);
			return Color.red;
		case 9:
			setCodigoCor (9);
			return Color.white;
		case 10:
			setCodigoCor (10);
			return Color.yellow;
		}
		return Color.black;
	}
}
