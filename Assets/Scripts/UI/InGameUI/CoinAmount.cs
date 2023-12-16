using TMPro;
using UnityEngine;


public class CoinAmount : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinAmount;
    public void UpdateCoinAmount(int newValue)
    {
        _coinAmount.text = newValue.ToString();
    }
}