using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    [Header("General Fields")]
    //List of items picked up
    public List<GameObject> items = new List<GameObject>();
    //flag indicates if the inventory is open or not
    public bool isOpen;
    [Header("UI Items Section")]
    //Inventory System Window
    public GameObject ui_Window;
    public Image[] items_images;
    [Header("UI Item Description")]
    public GameObject ui_Description_Window;
    public Image description_Image;
    public Text description_Title;
    public Text description_Text;


    private void Update()
    {
 
    }

    void ToggleInventory()
    {
        isOpen = !isOpen;
        ui_Window.SetActive(isOpen);

        Update_UI();
    }

    //Add the item to the items list
    public void PickUp(GameObject item)
    {
        items.Add(item);
        Update_UI();
    }

    //Refresh the UI elements in the inventory window    
    void Update_UI()
    {
        //For each item in the "items" list 
        //Show it in the respective slot in the "items_images"
        for (int i = 0; i < items.Count; i++)
        {
            items_images[i].sprite = items[i].GetComponent<SpriteRenderer>().sprite;
            items_images[i].gameObject.SetActive(true);
        }
    }
}