using System. Collections;
using System. Collections. Generic;
using UnityEngine;

public class Sphere: MonoBehaviour
{
    void Start ()
    {
        
    }
	
    void Update ()
    {
        if (Input. anyKey)
		{
			GetComponent <MeshRenderer> (). material. color = Color. blue;
		}
    }
}
