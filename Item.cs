using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float rotatespeed;


    void Update()
    {
        transform.Rotate(Vector3.up *rotatespeed * Time.deltaTime,Space.World ); 
    }


  




}
