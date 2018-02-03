using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo : MonoBehaviour
{
	public	float distanciahorizontal;
	public float distanciavertical;
	public TextAsset mundo_1; 
	public GameObject ladrillo;
	public int cant_i;
	public int cant_j;

	void Start () 
	{
	
		for (int i = 0; i < cant_i; i++) 
		{
			
			for (int j = 0; j < cant_j; j++)
			{
				GameObject go = Instantiate(ladrillo,this.transform);
				go.transform.localPosition = new Vector2 (i*distanciavertical,j*distanciahorizontal);
			}
		}
	}
	void Update () 
	{
		
	}
}
 