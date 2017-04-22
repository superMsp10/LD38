using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WorldBuilder : MonoBehaviour
{
    public GameObject planetIns;
    public int planetNum;
    public Transform planetsStart;

    public float amplitude;
    public GameObject player;



    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < planetNum; i++)
        {
            Instantiate(planetIns, Random.insideUnitSphere * (i + 1) * amplitude, Quaternion.identity, planetsStart);
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
