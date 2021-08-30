using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    
    
    PaddleControl paddleControlClass;
    private void Start()
    {
        paddleControlClass = EventManager.GetGameManagerClass();
    }


  

    

  
    public float sayac = .5f;
    private void OnTriggerStay(Collider other)
    {

        if (other.GetComponent<PaddleControl>())
        {
            Debug.Log("a");
            sayac -= Time.deltaTime;
            if (sayac < 0)
            {
                Debug.Log("b");
                paddleControlClass.RemoveFirsAndEndCyclinder();
                sayac = .5f;
            }

        }
    }
}
