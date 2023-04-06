using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class InventoryWindow : MonoBehaviour
{
    [SerializeField] RectTransform itemsPanel;
    [SerializeField] GameObject background;
    GraphicRaycaster m_Raycaster;
    EventSystem m_EventSystem;
    PointerEventData m_PointerEventData;

    readonly List<GameObject> drawnIcons = new List<GameObject> ();
    void Start()
    {
        Redraw();
        m_Raycaster = background.GetComponent<GraphicRaycaster>();
        m_EventSystem = background.GetComponent<EventSystem>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            background.SetActive(!background.activeSelf);
            if (background.activeSelf)
            {
                Redraw();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                //Set up the new Pointer Event
                m_PointerEventData = new PointerEventData(m_EventSystem);
                //Set the Pointer Event Position to that of the mouse position
                m_PointerEventData.position = Input.mousePosition;

                //Create a list of Raycast Results
                List<RaycastResult> results = new List<RaycastResult>();

                //Raycast using the Graphics Raycaster and mouse click position
                m_Raycaster.Raycast(m_PointerEventData, results);

                //For every result returned, output the name of the GameObject on the Canvas hit by the Ray
                foreach (RaycastResult result in results)
                {
                    Item item = Item.Load(result.gameObject.name);
                    if (item is not null && Inventory.items.ContainsKey(item))
                    {
                        Inventory.RemoveItem(result.gameObject.name);
                        Redraw();
                    }
                }
            }
        }

    }

    void OnItemAdded(Item obj) => Redraw();

    void Redraw()
    {
        ClearDrawn();
        foreach (KeyValuePair<Item, int> pair in Inventory.items)
        {
            for (int i = 1; i <= pair.Value; i++)
            {
                Item item = pair.Key;
                var icon = new GameObject(pair.Key.Name);
                icon.AddComponent<Image>().sprite = item.Icon;
                icon.transform.SetParent(itemsPanel);
                icon.transform.localScale = new Vector3(1f, 1f, 1f);
                drawnIcons.Add(icon);
            }  
        }
    }

    void ClearDrawn()
    {
        for (var i = 0; i < drawnIcons.Count; i++)
        {
            Destroy(drawnIcons[i]);
        }
        drawnIcons.Clear();
    }
}
