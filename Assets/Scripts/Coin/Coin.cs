using UnityEngine;

public class Coin : MonoBehaviour
{
    public void Destroy()
    {
        gameObject.SetActive(false);
    }
}
