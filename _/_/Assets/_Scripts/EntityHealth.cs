using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;
    [SerializeField] ParticleSystem impactPlayer;

    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    private void Start()
    {
        impactPlayer.Stop();
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

    void TakeDamage(int damage)
    {
        Debug.Log("Degats");
        CurrentHealth = CurrentHealth - damage;
        impactPlayer.Play();
    }

    public void AddVie(int heal)
    {
        CurrentHealth = CurrentHealth + heal;
    }


}
