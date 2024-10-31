using UnityEngine;
using UnityEngine.UI;

public class ShowGold : MonoBehaviour
{
    [SerializeField] EntityGold gold;
    [SerializeField] Text _numberGold;


    // Update is called once per frame
    void Update()
    {
        _numberGold.text = gold.CurrentGold.ToString();
    }
}
