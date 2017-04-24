using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class HintPlanet : MonoBehaviour
{
    int hintType;
    public Text hintText;
    Person theif;
    public GameObject arrow;

    // Use this for initialization
    void Start()
    {

        hintText.text = "Hover over screen to reveal hint";

        theif = WorldBuilder.thisBuilder.theif;


        switch (WorldBuilder.thisBuilder.hintNumber % 5)
        {
            case 0:
                hintText.text = "The theif's colour is: " + theif.colourName;
                break;

            case 1:
                hintText.text = "The theif's planet is: " + theif.planetType;
                break;

            case 2:
                hintText.text = "The theif's is: " + Vector3.Distance(transform.position, theif.transform.position) + "m away from here.";
                break;

            case 3:
                hintText.text = "The theif's is a " + theif.personType;
                break;

            case 4:
                hintText.text = "The theif's is that way!";
                arrow.SetActive(true);
                arrow.transform.LookAt(theif.gameObject.transform);

                break;

            default:
                hintText.text = "The theif's is on a planet: ";
                break;
        }
        WorldBuilder.thisBuilder.hintNumber++;

    }


}
