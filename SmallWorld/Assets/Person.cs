using UnityEngine;
using System.Collections;

public class Person : MonoBehaviour
{
    public bool theif = false;
    public string personType;
    public string planetType;
    public string colourName = "";


    public Color normal;
    public Renderer mat;

    public bool activated = true;

    void OnMouseOver()
    {

        if (activated && Input.GetMouseButtonDown(1))
        {
            if (theif)
            {
                WorldBuilder.thisBuilder.EndGame();
            }
            else
            {
                StartCoroutine(WorldBuilder.thisBuilder.ShowDialog(5f, "Nope. Was not me. Gotta go!"));
                Invoke("destroySelf", 6f);
                activated = false;

            }
        }
    }

    void destroySelf()
    {
        Destroy(gameObject);
    }
    void OnMouseEnter()
    {
        if (activated)
            mat.material.color = Color.red;
    }

    void OnMouseExit()
    {
        if (activated)
            mat.material.color = normal;
    }

}
