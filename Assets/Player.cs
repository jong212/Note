using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    private IWeapon currentWeapon;
    private List<IWeapon> weapons = new List<IWeapon>();

    void Start()
    {
        // �ڽ� ������Ʈ���� ��� ����(IWeapon �������̽��� ������ ������Ʈ)�� ã���ϴ�.
        weapons.AddRange(GetComponentsInChildren<IWeapon>());

        // �⺻ ����� ù ��° ���⸦ �����մϴ�.
        if (weapons.Count > 0)
        {
            EquipWeapon(0);
        }
        else
        {
            Debug.LogError("No weapons found on this player.");
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            currentWeapon?.Attack(); // �����ϱ�
        }

        if (Input.GetButtonDown("Reload"))
        {
            currentWeapon?.Reload(); // �������ϱ�
        }

        // ���� ����: 1�� Ű�� ������ �� ù ��° ����, 2�� Ű�� ������ �� �� ��° ���� ����
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EquipWeapon(0); // ù ��° ���� ����
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && weapons.Count > 1)
        {
            EquipWeapon(1); // �� ��° ���� ����
        }
        // �ʿ��� ��� �� ���� ���� ������ �߰��� �� �ֽ��ϴ�.
    }

    private void EquipWeapon(int index)
    {
        currentWeapon = weapons[index];
        Debug.Log("Equipped weapon: " + currentWeapon.GetType().Name);
    }
}
