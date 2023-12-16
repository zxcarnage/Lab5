
using UnityEngine;

public static class ServiceLocator
{
    public static BulletSpawner BulletSpawner { get; set; }
    public static Camera MainCamera { get; set; }

    public static Player Player { get; set; }
    
    public static MainUI MainUI { get; set; }
}
