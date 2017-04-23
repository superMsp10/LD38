using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Teleporter : MonoBehaviour
{

    public Transform teleTo;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c)
    {
        List<Teleporter> t = WorldBuilder.thisBuilder.allTeles;
        Transform trans = t[Random.Range(0, t.Count)].transform;

        c.transform.position = trans.position + Vector3.Normalize(c.GetComponent<Rigidbody>().velocity);
    }


}
