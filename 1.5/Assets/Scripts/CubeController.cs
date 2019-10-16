using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public string oreType;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnMouseDown()
    {
        Destroy(gameObject);
        if (oreType == "Bronze")
        {
            ControllerScript.bronzeSupply--;
        }
        else if (oreType == "Silver")
        {
            ControllerScript.silverSupply--;
        }
    }
}