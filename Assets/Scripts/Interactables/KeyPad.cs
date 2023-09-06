using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : Interactable
{

    [SerializeField]
    private GameObject door;
    private bool doorOpen = false;

    protected override void interact(){
        Debug.Log("interact with: " + gameObject.name);
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("isOpen", doorOpen);
    }

}
