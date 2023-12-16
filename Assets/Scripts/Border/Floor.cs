using System;
using UnityEngine;


public class Floor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnTriggerEnter2D");
        if (col.TryGetComponent(out JetpackBullet bullet))
        {
            bullet.Destroy();
        }
            
    }
}
