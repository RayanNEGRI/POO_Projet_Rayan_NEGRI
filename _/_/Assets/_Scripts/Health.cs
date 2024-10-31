using UnityEngine;

public abstract class Health
{
    int _maxHealth;
    int _currentLife;

    public Health(int maxHealth)
    {
        _maxHealth = maxHealth;
    }


    public int CurrentLife
    {
        get { return _currentLife; }
        set { _currentLife = value; }
    }

    internal string MaxHealth => _maxHealth;

    public abstract int AddHeal();

}
