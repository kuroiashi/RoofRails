using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    public List<GameObject> PaddleHolder = new List<GameObject>();
    public GameObject Cyclinder;
    public GameObject LastChild;
    public Vector3 NewPosition;


    private void Start()
    {

        UpdatePaddleHolder();
       
    }



    private void OnEnable()
    {
        EventManager.GetGameManagerClass += GiveGameManagerClass;
    }
    private void OnDisable()
    {
        EventManager.GetGameManagerClass -= GiveGameManagerClass;
    }
    private PaddleControl GiveGameManagerClass()
    {
        return GetComponent<PaddleControl>();
    }
   
    
    
    
    
    
  
    
    
    
    
    public void RemoveFirsAndEndCyclinder()
    {
        PaddleHolder[0].transform.parent = null;
        Destroy(PaddleHolder[0]);
        PaddleHolder[PaddleHolder.Count - 1].transform.parent = null;
        Destroy(PaddleHolder[PaddleHolder.Count - 1]);
        UpdatePaddleHolder();





    }


    public void AddCyclinder()
    {
        LastChild = transform.GetChild(transform.childCount - 1).gameObject;
        NewPosition = LastChild.transform.position + new Vector3(0.2f, 0, 0);
        Cyclinder = Instantiate(Cyclinder, NewPosition, Quaternion.identity);
        Cyclinder.transform.rotation = LastChild.transform.rotation;
        Cyclinder.transform.SetParent(transform);
        UpdatePaddleHolder();



    }


    public void UpdatePaddleHolder()
    {
        //PaddleHolder.Clear();   ?????????????????????????????????????????????????????????????????????????????????????
        //for (int i = 0; i <PaddleHolder.Count; i++)
        //{
        //    PaddleHolder.RemoveAt(i);
        //}
        PaddleHolder.Clear();

        for (int k = 0; k < transform.childCount; k++)
        {
            PaddleHolder.Add(transform.GetChild(k).gameObject);
        }
    }

   
    public void MovingCenterOfPaddle()
    {
        int CenterCyclinderIndex = (transform.childCount / 2);

        transform.position = transform.GetChild(CenterCyclinderIndex).transform.position;
    }


    
    
    
    




}
