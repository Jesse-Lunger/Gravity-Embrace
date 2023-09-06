using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // Template method pattern
    public string promptMessage;
    public void baseInteract(){
        interact();
    }
    protected virtual void interact(){

    }
}
