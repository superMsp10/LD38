using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class pickUps : MonoBehaviour
{

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            onPlayerContact(c.gameObject.GetComponent< RigidbodyFirstPersonController>());
        }
    }
    
    public virtual void onPlayerContact(RigidbodyFirstPersonController p)
    {
        Debug.Log("Player contact on pickup");
        Destroy(gameObject);
    }
}
