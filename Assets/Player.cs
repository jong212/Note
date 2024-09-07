using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    private IWeapon currentWeapon;
    private List<IWeapon> weapons = new List<IWeapon>();

    void Start()
    {
        // 자식 오브젝트에서 모든 무기(IWeapon 인터페이스를 구현한 컴포넌트)를 찾습니다.
        weapons.AddRange(GetComponentsInChildren<IWeapon>());

        // 기본 무기로 첫 번째 무기를 선택합니다.
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
            currentWeapon?.Attack(); // 공격하기
        }

        if (Input.GetButtonDown("Reload"))
        {
            currentWeapon?.Reload(); // 재장전하기
        }

        // 무기 변경: 1번 키를 눌렀을 때 첫 번째 무기, 2번 키를 눌렀을 때 두 번째 무기 선택
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EquipWeapon(0); // 첫 번째 무기 장착
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && weapons.Count > 1)
        {
            EquipWeapon(1); // 두 번째 무기 장착
        }
        // 필요한 경우 더 많은 무기 슬롯을 추가할 수 있습니다.
    }

    private void EquipWeapon(int index)
    {
        currentWeapon = weapons[index];
        Debug.Log("Equipped weapon: " + currentWeapon.GetType().Name);
    }
}
