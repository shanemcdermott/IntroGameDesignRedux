using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static PlayerController instance;

    public GameObject controlledObject;
    

	// Use this for initialization
	void Awake ()
    {
		if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this)
        {
            DestroyImmediate(this);
        }
        
	}
	
    public GameObject GetControlledObject()
    {
        return controlledObject;
    }



	// Update is called once per frame
	void Update ()
    {

	}
}
