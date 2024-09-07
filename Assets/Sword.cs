using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("Sword slashing!");
    }

    public void Reload()
    {
        Debug.Log("Sword reloading!");
    }
}
