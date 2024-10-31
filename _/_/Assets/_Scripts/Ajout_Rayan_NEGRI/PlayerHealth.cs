using UnityEngine;

public class PlayerHealth : Health
{

    public PlayerHealth(string maxHealth) : base(maxHealth)
    {

    }

    public override int AddHeal()
    {
        return CurrentLife + 20;
    }
}
