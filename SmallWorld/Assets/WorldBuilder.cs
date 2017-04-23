using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class WorldBuilder : MonoBehaviour
{
    public int planetNum;
    public Transform planetsStart;

    public float amplitude;
    public GameObject player;

    public List<Teleporter> allTeles = new List<Teleporter>();
    public List<Text> allHints = new List<Text>();
    public GameObject[] allPlanets;

    public static WorldBuilder thisBuilder;

    void Awake()
    {
        thisBuilder = this;
    }


    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < planetNum; i++)
        {
           GameObject g = (GameObject) Instantiate( allPlanets[Random.Range(0,allPlanets.Length)] , Random.insideUnitSphere * planetNum * amplitude, Quaternion.identity, planetsStart);
            if(g.tag == "TelePlanet")
            {
                allTeles.Add(g.GetComponentInChildren<Teleporter>());
            }else if(g.tag == "HintPlanet")
            {
                allHints.Add(g.GetComponentInChildren<Text>());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -planetNum * amplitude)
        {
            SceneManager.LoadScene(0);
        }
    }
}
