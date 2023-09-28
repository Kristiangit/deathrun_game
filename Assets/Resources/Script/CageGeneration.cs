using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageGeneration : MonoBehaviour
{
    public GameObject CagePrefab; 


    
    void Start()
    {
        CagePrefab = Resources.Load("Prefab/environment") as GameObject;
    }


    // Update is called once per frame
    void Update()
    {





    }
}
