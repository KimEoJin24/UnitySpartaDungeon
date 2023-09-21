using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject statusPanel;
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private GameObject jobStoryPanel;
    [SerializeField] private GameObject equipQ;
    [SerializeField] private GameObject equipment;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

        statusPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        jobStoryPanel.SetActive(false);
        
    }

    public void JobButton()
    {
        jobStoryPanel.SetActive(true);
    }

    public void StatusButton()
    {
        statusPanel.SetActive(true);
    }

    public void InventoryButton()
    {
        inventoryPanel.SetActive(true);
    }

    public void JobStoryPanelExit()
    {
        jobStoryPanel.SetActive(false);
    }

    public void StatusPanelExit()
    {
        statusPanel.SetActive(false);
    }

    public void InventoryPanelExit()
    {
        inventoryPanel.SetActive(false);
    }

    public void EquipQ()
    {
        equipQ.SetActive(true);
    }

    public void EquipQCancel()
    {
        equipQ.SetActive(false);
    }

    public void EquipQConfirm()
    {
        equipQ.SetActive(false);
        if (equipment == true)
        {
            equipment.SetActive(false);
        }
        else
        {
            equipment.SetActive(true);
        }
    }
}
