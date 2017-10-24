using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject Objetivo;    
    private float r = 0;
    public Rigidbody2D RB;

    // Use this for initialization
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Objetivo = gameObject;        
        r = 20;
        Objetivo = objetivo;


    }

    // Update is called once per frame
    void Update()
    {       


    }


}
