using UnityEngine;

public class Gun : MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("Gun shooting!");
    }

    public void Reload()
    {
        Debug.Log("Gun reloading!");
    }
}
