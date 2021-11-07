using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclinderMovement : MonoBehaviour
{
    PaddleControl paddleControl;

    private void Start()
    {
        paddleControl = EventManager.GetGameManagerClass.Invoke();
       
    }



    private void OnEnable()
    {
        EventManager.PickUpFriendPaddle.AddListener(PickUpFriendPaddle);
    }
    private void OnDisable()
    {
        EventManager.PickUpFriendPaddle.RemoveListener(PickUpFriendPaddle);

    }
    private void PickUpFriendPaddle()
    {
        
        transform.position += new Vector3(-0.2f, 0, 0);
    }



    



    // Cut Cyclinder 

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.GetComponent<SawControl>())
        {
           
            int FirstValue = paddleControl.PaddleHolder.IndexOf(gameObject);
            int SecondValue = paddleControl.PaddleHolder.Count;
           


            if (paddleControl.transform.position.x < collision.gameObject.transform.position.x)

            {
                for (int i = FirstValue; i < SecondValue; i++)
                {

                    paddleControl.PaddleHolder[i].gameObject.transform.parent = null;    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    Destroy(paddleControl.PaddleHolder[i]);
                    
                    
                    
                }
                paddleControl.UpdatePaddleHolder();
                
;
                

            }
            if (paddleControl.transform.position.x >= collision.gameObject.transform.position.x)
            {
                
                int ColliderCyclinder2 = paddleControl.PaddleHolder.IndexOf(gameObject);
                for (int i = ColliderCyclinder2; i >= 0 ; i--)
                {
                    paddleControl.PaddleHolder[i].gameObject.transform.parent = null;      //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


                    Destroy(paddleControl.PaddleHolder[i]);
                  
                    

                }
                paddleControl.UpdatePaddleHolder();
            }


        }
    }





}
