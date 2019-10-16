using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
   
    public static int bronzeSupply = 0;
    public static int silverSupply = 0;
    public static int goldSupply = 0;
    bool spawnGold = false; //should we spawn a gold
    float mineNow;
    float miningSpeed = 3;
    public GameObject redPrefab;
    public GameObject silverPrefab;
    public GameObject goldPrefab;
    public Vector3 cubePosition;
    int xPos = 0;
    GameObject MyCube;
    string lastOre;
   

    // Start is called before the first frame update
    void Start()
    {
        mineNow = miningSpeed;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (bronzeSupply == 2 && silverSupply == 2 && lastOre!= "gold")
        {
            spawnGold = true;
        }
        if (Time.time > mineNow)
        {
            mineNow += miningSpeed;
            if (spawnGold)
            {
                goldSupply++;
                spawnGold = false;
                cubePosition = new Vector3(xPos, 2, 0);
                MyCube = Instantiate(goldPrefab, cubePosition, Quaternion.identity);
                MyCube.GetComponent<CubeController>().oreType = "Gold";
                lastOre = "gold";
            }
            else if (bronzeSupply < 4)
            {
                
                bronzeSupply++;
                cubePosition = new Vector3(xPos, 0, 0);
                MyCube=Instantiate(redPrefab, cubePosition, Quaternion.identity);
                MyCube.GetComponent<CubeController>().oreType = "Bronze";
                xPos+=2;
                lastOre = "bronze";
            }
          
            else 
            {
                silverSupply++;
                cubePosition = new Vector3(xPos, -2, 0);
                MyCube=Instantiate(silverPrefab, cubePosition, Quaternion.identity);
                MyCube.GetComponent<CubeController>().oreType = "Silver";
                xPos -= 2;
                lastOre = "silver";
            }
            print("Bronze: " + bronzeSupply+"Silver: " + silverSupply+ "Gold: "+goldSupply);
        }

    }
}
