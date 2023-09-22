using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Button slot;
    [SerializeField] private GameObject equipment;
    [SerializeField] private Button equipQConfirm;
    bool isSwitch = true;


    private void Start()
    {
        if (slot != null)
        {
            slot.onClick.AddListener(GameManager.instance.EquipQ);
        }

        if (equipQConfirm != null)
        {
            equipQConfirm.onClick.AddListener(GameManager.instance.EquipQConfirm);
            equipQConfirm.onClick.AddListener(EquipmentSwitch);
        }
    }

    public void EquipmentSwitch()
    {
        if (isSwitch == true)
        {
            equipment.SetActive(false);
            isSwitch = false;
        }
        else
        {
            equipment.SetActive(true);
            isSwitch = true;
        }
    }
}
