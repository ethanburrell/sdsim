using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_random : MonoBehaviour
{
    // Start is called before the first frame update
    public float x;
    public float y;
    public float z;
    Vector3 pos;
    public GameObject obj;
    void Start()
    {
        x = Random.Range(-25, 26);
        y = 5;
        z = Random.Range(-25, 26);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(-25, 26);
        y = 5;
        z = Random.Range(-25, 26);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }
}
