using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartBase : MonoBehaviour
{
    [SerializeField]
    public BodyPartData bodyPartData;

    public GameObject AttachedObject;

    protected HealthComponent health;

    private void Awake()
    {
        if(health == null)
        {
            health = GetComponent<HealthComponent>();
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
