using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObjects : MonoBehaviour
{
    public GameObject prefabToPlace; // Assign the prefab in the inspector
    
   
    public Vector3 NPostion;
    public Quaternion NRotation;
    

    
   
    public void OnClick()
    {
       
        Instantiate(prefabToPlace, NPostion, NRotation);
    }
    

 

}



