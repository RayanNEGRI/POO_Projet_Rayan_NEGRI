using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGold : MonoBehaviour
{
    public int CurrentGold { get; private set; }

    public void AddGold(int money)
    {
        CurrentGold = CurrentGold + money;
    }
}
