using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KocurScript : MonoBehaviour
{
    public Transform movePoint;
    private void Start()
    {
        EventManager.ExampleEvent += MoveTheCat;
    }

    public void MoveTheCat()
    {
        float y = 0;
        float x = 0;
        transform.localPosition = Vector2.MoveTowards(transform.position, movePoint.position, 5 * Time.deltaTime);
    }
    
        
    
 
}
