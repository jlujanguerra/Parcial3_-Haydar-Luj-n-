using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour {

    public GameObject Player;
    public GameObject Objetivo;
    public float radio = 20;

	// Use this for initialization
	void Start () {

        DistanciaValida();

    }
	
	// Update is called once per frame
	void Update () {

        


    }

    void DistanciaValida()
    {
        if (Vector3.Distance(Player.transform.position, Objetivo.transform.position) <= radio)
        {
                        Debug.Log("detectado");
            
        }
    }
        
        
    }
        

