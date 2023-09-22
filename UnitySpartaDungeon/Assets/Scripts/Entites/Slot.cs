using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Button slot;
    
    
    bool isSwitch = true;

    private void Start()
    {
        if (slot != null)
        {
            slot.onClick.AddListener(GameManager.instance.EquipQ);
        }
    }   
}
