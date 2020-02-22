using UnityEngine;
using System.Collections.Generic;

public class ItemSystem : MonoBehaviour
{
    [Header("列數"), Range(1, 30)]
    public int row;
    [Header("欄數"), Range(1, 30)]
    public int col;
    [Header("空白道具欄")]
    public GameObject item;

    private Transform itemParent;
    [HideInInspector]
    public List<ItemEmpty> itemEmptys = new List<ItemEmpty>();

    private void Start()
    {
        CreateItem();
    }

    private void CreateItem()
    {
        itemParent = GameObject.Find("道具欄物件").transform;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                GameObject temp = Instantiate(item, itemParent);
                temp.AddComponent<ItemEmpty>();
                itemEmptys.Add(temp.GetComponent<ItemEmpty>());
            }
        }
    }
}
