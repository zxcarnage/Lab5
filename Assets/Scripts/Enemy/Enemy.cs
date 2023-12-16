using UnityEngine;


public abstract class Enemy : MonoBehaviour, IDieable
{
    public virtual void Die()
    {
        gameObject.SetActive(false);
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.TryGetComponent(out Player player))
        {
            player.Die();
            ServiceLocator.MainUI.ShowLoseScreen();
        }
        else
            gameObject.SetActive(false);
    }
}
