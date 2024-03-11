using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public GameObject roadPrefab;
    public float offset = 0.707f;

    public Vector3 Lastpos;

    private int roadCount = 0;

    public void StartBuilding()
    {
        InvokeRepeating("CreateNewRoad", 1f, .5f);
    }

    public void CreateNewRoad()
    {
        Debug.Log("The user pressed the button");

        Vector3 spawnpos = Vector3.zero;

        float chance = Random.Range(0, 100);
        if(chance < 50)
        {
            spawnpos = new Vector3(Lastpos.x + offset, Lastpos.y, Lastpos.z + offset);
        }
        else
        {
            spawnpos = new Vector3(Lastpos.x -  offset, Lastpos.y, Lastpos.z + offset);
        }

        GameObject g = Instantiate(roadPrefab, spawnpos, Quaternion.Euler(0,45,0));
        Lastpos = g.transform.position;

        roadCount++;
        if(roadCount % 5 == 0)
        {
            g.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
   
}
