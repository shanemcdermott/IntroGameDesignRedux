using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingBase : MonoBehaviour
{
    public List<BodyPartBase> bodyParts = new List<BodyPartBase>();

    protected Dictionary<string, BodyPartBase> parts = new Dictionary<string, BodyPartBase>();

    private void Awake()
    {
        foreach(BodyPartBase b in bodyParts)
        {
            parts.Add(b.bodyPartData.name, b);
        }
    }

    // Use this for initialization
    void Start ()
    {
	    	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
