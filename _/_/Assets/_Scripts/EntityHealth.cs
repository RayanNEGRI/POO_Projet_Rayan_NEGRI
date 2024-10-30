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

    //private void OnValidate()
    //{
    //    if (_maxHealth <= 0)
    //    {
    //        _maxHealth = 100;
    //        Debug.Log("Erreur la vie max du joueur est inf�rieur ou �gal � 0 , alors je vais la remettre � 100 automatiquement");
    //    }

    //    if (CurrentHealth <= 0)
    //    {
    //        CurrentHealth = 1;
    //        Debug.Log("Erreur la vie du joueur est inf�rieur ou �gal � 0 , alors je vais la remettre � 1 automatiquement");
    //    }
    //}

    //private void Reset()
    //{
    //    Debug.Log("Objet Initialis�");
    //    _maxHealth = 100;
    //}

    void TakeDamage(int damage)
    {
        //if (damage <= 0)
        //{
        //    Debug.LogError("damage must be positive");
        //    return;
        //}

        ////death
        //if (CurrentHealth <= 0)
        //{
        //    //Die();
        //}

        CurrentHealth = CurrentHealth - damage;
        Debug.Log("Degats");
        //impactPlayer.Play();
    }


}
