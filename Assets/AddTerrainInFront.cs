using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTerrainInFront : MonoBehaviour
{
    // Start is called before the first frame update
    public Terrain terrain;
    void Start()
    {
        GameObject t = GameObject.FindGameObjectsWithTag("terrain1")[0];
        Debug.Log("AddTerrainInFront " + this.transform.position);
        t.transform.position = new Vector3(this.transform.position.x - .5f * this.transform.position.x, 0, this.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
