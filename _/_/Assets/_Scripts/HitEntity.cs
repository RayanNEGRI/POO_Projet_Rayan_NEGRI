using NaughtyAttributes;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitEntity : MonoBehaviour
{
    [SerializeField] InputActionReference _attack; 
    [SerializeField] int _damage = 10; // Dégâts infligés par l'attaque
    [SerializeField] bool _attackState;
    Collider _target;


    public event Action OnStartAttack; 
    public event Action OnStopAttack;  

    private void Start()
    {
        _attack.action.started += StartAttack;
        _attack.action.canceled += StopAttack;
    }

    private void OnDestroy()
    {
        _attack.action.started -= StartAttack;
        _attack.action.canceled -= StopAttack;
    }

    private void StartAttack(InputAction.CallbackContext obj)
    {
        OnStartAttack?.Invoke();
        Debug.Log("Attack ON");

        if (_attackState && _target)
        {
            _target.SendMessage("TakeDamage", _damage);
        }
        else
        {
            Debug.Log("Le joueur n'as pas de cible à proximiter , IMPOSSIBLE D ATTAQUER !!! ERROR");
        }

    }

    private void StopAttack(InputAction.CallbackContext obj)
    {
        Debug.Log("Attack OFF");
        OnStopAttack?.Invoke(); 
    }

    void OnTriggerEnter(Collider enemy)
    {
        if (enemy.tag == "Enemy")
        {
            _attackState = true;
            _target = enemy;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.tag == "Enemy")
        {
            _attackState = false;
            _target = null;
        }
    }
}
