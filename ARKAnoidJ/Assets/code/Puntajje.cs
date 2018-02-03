using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puntajje : MonoBehaviour 
{
	public int vp;
	public int vp2;
	public int vp3;
	public int vp4;
	public int puntosvida = 3;
	public Text vidas;
    public static int puntos = 0 ;
	public Text play1;
 
    public void puntop1 ()
	{
		General.puntos = General.puntos + vp;
	 	play1.text = "Punto: " + General.puntos.ToString();
        if (General.puntos == 100)
        {
            puntosvida = puntosvida + 1;
        }
            if (General.puntos == 1600) 
		{
			SceneManager.LoadScene ("Nivel_2");
		}
		if (General.puntos == 3000) 
		{
			SceneManager.LoadScene ("Nivel_3");
		}
		if (General.puntos == 12400) 
		{
			SceneManager.LoadScene ("MENU");
		}
	}

    public void puntop2 ()
	{
		General.puntos = General.puntos + vp2;
		play1.text = "Punto: " + General.puntos.ToString();
        if (General.puntos == 100)
        {
            puntosvida = puntosvida + 1;
        }
        if (General.puntos == 1600) 
		{
			SceneManager.LoadScene ("Nivel_2");
		}
		if (General.puntos == 3000) 
		{
			SceneManager.LoadScene ("Nivel_3");
		}
		if (General.puntos == 9000) 
		{
			SceneManager.LoadScene ("MENU");
		}
	}

	public void puntop3 ()
	{
		General.puntos = General.puntos + vp3;
		play1.text = "Punto: " + General.puntos.ToString();
        if (General.puntos == 100)
        {
            puntosvida = puntosvida + 1;
        }

        if (General.puntos == 1600) 
		{
			SceneManager.LoadScene ("Nivel_2");
		}
		if (General.puntos == 3000) 
		{
			SceneManager.LoadScene ("Nivel_3");
		}
		if (General.puntos == 9000) 
		{
			SceneManager.LoadScene ("MENU");
		}
	}

	public void puntop4 ()
	{
		General.puntos = General.puntos + vp4;
		play1.text = "Punto: " + General.puntos.ToString();
        if (General.puntos == 100)
        {
            puntosvida = puntosvida + 1;
        }
        if (General.puntos == 1600) 
		{
			SceneManager.LoadScene ("Nivel_2");
		}
		if (General.puntos == 3000) 
		{
			SceneManager.LoadScene ("Nivel_3");
		}
		if (General.puntos == 9000) 
		{
			SceneManager.LoadScene ("MENU");
		}

    }

public void puntovida ()

	{
		puntosvida = puntosvida - 1;
		vidas.text = puntosvida.ToString ();
		if (puntosvida <= 0)
		{
			SceneManager.LoadScene ("GameOver");
		}

        
    }
}

