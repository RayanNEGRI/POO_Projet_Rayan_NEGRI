using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowHealth : MonoBehaviour
{
    [SerializeField] EntityHealth _health;
    [SerializeField] Slider _slider;
    [SerializeField] Text _numberHealth;


    // Update is called once per frame
    void Update()
    {
        _slider.value = _health.MaxHealth;
        _numberHealth.text = _slider.value.ToString();
    }
}
