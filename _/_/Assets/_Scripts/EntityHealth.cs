using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;
    [SerializeField] ParticleSystem impactPlayer;
    [SerializeField] Animator _anim;


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

    private void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public int GetMaxHealth() { return _maxHealth; }

    void TakeDamage(int damage)
    {
        CurrentHealth = CurrentHealth - damage;
        impactPlayer.Play();

        if (_anim)
        {
            _anim.SetTrigger("GetHit");
        }
        else
        {
            Debug.Log("Pas d'anim dispo pour le composant quand il prend un dégats");
        }
            
    }

    public void AddLife(int heal)
    {
        CurrentHealth = CurrentHealth + heal;
    }


}
