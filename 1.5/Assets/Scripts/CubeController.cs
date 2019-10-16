using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    int bronzePoints = 1;
    int silverPoints = 10;
    int goldPoints = 100;
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
            ControllerScript.pointTotal += bronzePoints;
        }
        else if (oreType == "Silver")
        {
            ControllerScript.silverSupply--;
            ControllerScript.pointTotal += silverPoints;
        }
        else if (oreType == "Gold")
        {
            Controllerscript.goldSupply--;
            ControllerScript.pointTotal += goldPoints;
        }
    }
}