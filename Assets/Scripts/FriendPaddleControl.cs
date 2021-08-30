using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendPaddleControl : MonoBehaviour
{
    private PaddleControl PaddleControl;
    private void Start()
    {
       PaddleControl = EventManager.GetGameManagerClass();
    }
    
    
    
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PaddleControl>())
        {
            EventManager.PickUpFriendPaddle.Invoke();
            Destroy(gameObject);
            PaddleControl.AddCyclinder();
            PaddleControl.AddCyclinder();

        }
    }
}
