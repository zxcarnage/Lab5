using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BulletSpawner : ObjectPool
{
    [SerializeField] private float _spreadingRadius;
    [SerializeField] private float _yOffset;
    [SerializeField] private float _sphereY;

    private Vector3 _playerPosition;
    private Vector3 _sphereCentrePoint;
    
    private void Awake()
    {
        ServiceLocator.BulletSpawner = this;
    }

    private void Start()
    {
        Initialize();
    }

    public void Spawn()
    {
        if (TryGetElement(out GameObject gameObject))
        {
            CalculatePosition();
            var instantiatedBullet = gameObject.GetComponent<JetpackBullet>();
            instantiatedBullet.transform.position = new Vector2(_playerPosition.x, _playerPosition.y + _yOffset);
            var random = Random.insideUnitCircle;
            var aimPoint = (Vector2)_sphereCentrePoint + random * _spreadingRadius;
            // Debug.Log($"Sphere center:{_sphereCentrePoint}, Random in unit: {random}, Random multiplyied: " +
            //           $"{random*_spreadingRadius}, Final: {aimPoint} ");
            instantiatedBullet.gameObject.SetActive(true);
            instantiatedBullet.Shoot(aimPoint);
        }
    }

    private void CalculatePosition()
    {
        _playerPosition = ServiceLocator.Player.transform.position;
        _sphereCentrePoint = new Vector2(0f, _sphereY);
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(new Vector2(_playerPosition.x, _playerPosition.y + _sphereY), _spreadingRadius);
    }
    
}
