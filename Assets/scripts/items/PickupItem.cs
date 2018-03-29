using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : ItemBase
{
    public Animator animator;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        animator.SetBool("highlight", true);
    }

    private void OnMouseExit()
    {
        animator.SetBool("highlight", false);
    }

    private void OnMouseDown()
    {
        if (PlayerController.instance.GetControlledObject().GetComponent<Inventory>().AddItem(itemData))
        {
            Destroy(gameObject);
        }
    }
}
