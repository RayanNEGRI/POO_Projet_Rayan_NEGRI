using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] int nbrHeal;
    public PlayerHealth(int maxHealth) : base(maxHealth)
    {

    }

    public override int AddHeal()
    {
        return CurrentLife + nbrHeal;
    }
}
