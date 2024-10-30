using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;

    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public int MaxHealth
    {
        get { return _maxHealth; }
        set
        {
            if (value <= 0)
            {
                Debug.Log("Erreur");
                return;
            }

            _maxHealth = value;
        }
    }

    public int GetMaxHealth() { return _maxHealth; }



}
