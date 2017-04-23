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


    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(1))
        {
            if (theif)
            {
              WorldBuilder.thisBuilder.EndGame();
            }
            else
            {
                StartCoroutine(WorldBuilder.thisBuilder.ShowDialog(5f, "Nope. Was not me."));
            }
        }
    }

    void OnMouseEnter()
    {
        mat.material.color = Color.red;
    }

    void OnMouseExit()
    {
        mat.material.color = normal;
    }

}
