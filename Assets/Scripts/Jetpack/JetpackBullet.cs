using System;
using UnityEngine;

[RequireComponent(typeof(IJetpackBulletMover))]
public class JetpackBullet : MonoBehaviour
{
    private IJetpackBulletMover _jetpackBulletMover;

    private void Awake()
    {
        _jetpackBulletMover = GetComponent<IJetpackBulletMover>();
    }

    public void Shoot(Vector3 point)
    {
        _jetpackBulletMover.Shoot(point);
    }

    public void Destroy()
    {
        gameObject.SetActive(false);
    }
}
