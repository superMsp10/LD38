using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

class BoostStrengthIncrement : pickUps
{
    public int increment;

    public override void onPlayerContact(RigidbodyFirstPersonController p)
    {
        p.boostAmount += increment;
        base.onPlayerContact(p);
    }

}

