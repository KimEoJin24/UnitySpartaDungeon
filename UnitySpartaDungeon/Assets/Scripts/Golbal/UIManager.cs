using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Button jobButton;
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    [SerializeField] private Button jobStoryPanelExit;
    [SerializeField] private Button statusPanelExit;
    [SerializeField] private Button inventoryPanelExit;
    [SerializeField] private Button slot;
    [SerializeField] private Button equipQCancel;
    [SerializeField] private Button equipQConfirm;

    private void Start()
    {
        if(jobButton != null)
        {
            jobButton.onClick.AddListener(GameManager.instance.JobButton);
        }

        if(statusButton != null)
        {
            statusButton.onClick.AddListener(GameManager.instance.StatusButton);
        }

        if(inventoryButton != null)
        {
            inventoryButton.onClick.AddListener(GameManager.instance.InventoryButton);
        }

        if(jobStoryPanelExit != null)
        {
            jobStoryPanelExit.onClick.AddListener(GameManager.instance.JobStoryPanelExit);
        }

        if(statusPanelExit != null)
        {
            statusPanelExit.onClick.AddListener(GameManager.instance.StatusPanelExit);
        }

        if(inventoryPanelExit != null)
        {
            inventoryPanelExit.onClick.AddListener(GameManager.instance.InventoryPanelExit);
        }

        if(slot != null)
        {
            slot.onClick.AddListener(GameManager.instance.EquipQ);
        }

        if(equipQCancel != null)
        {
            equipQCancel.onClick.AddListener(GameManager.instance.EquipQCancel);
        }

        if(equipQConfirm != null)
        {
            equipQConfirm.onClick.AddListener(GameManager.instance.EquipQConfirm);
        }

    }
}
