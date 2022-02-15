using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    public enum InteractionType { NONE, PickUp, Examine, GrabDrop, CamSwap, kick }
    [Header("Attributes")]
    public InteractionType interactType;
    [Header("Examine")]
    public string descriptionText;
    [Header("Custom Events")]
    public UnityEvent customEvent;


    private void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;
        gameObject.layer = 10;
    }

    public void Interact()
    {
        switch (interactType)
        {
            case InteractionType.PickUp:
                //Add the object to the PickedUpItems list
                FindObjectOfType<InventorySystem>().PickUp(gameObject);
                //Disable
                gameObject.SetActive(false);
                break;
            case InteractionType.Examine:
                //Call the Examine item in the interaction system
                FindObjectOfType<InteractionSystem>().ExamineItem(this);
                break;
            case InteractionType.GrabDrop:
                //Grab interaction
                FindObjectOfType<InteractionSystem>().GrabDrop();
                break;
            case InteractionType.CamSwap:
                FindObjectOfType<InteractionSystem>().SwapCam();
                break;
            case InteractionType.kick:
                FindObjectOfType<InteractionSystem>().Kopaniec();
            break;
            default:
                Debug.Log("NULL ITEM");
                break;
        }
    }
}