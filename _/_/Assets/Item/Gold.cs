using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{
    public EntityGold entityGold;

    public override void Use(PickUpItem pui)
    {
        base.Use(pui);
        Debug.Log("Le Joueur reçoit de la vie");
        entityGold.AddGold(20);
    }
}
