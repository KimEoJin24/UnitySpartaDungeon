using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment : MonoBehaviour
{
    [SerializeField] private GameObject equipment;
    [SerializeField] private Button equipQConfirm;
    bool isSwitch = true;

    private void Start()
    {
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
            GameManager.instance.equipments[0].SetActive(false);
            isSwitch = false;
        }
        else
        {
            GameManager.instance.equipments[0].SetActive(true);
            isSwitch = true;
        }
    }
}
