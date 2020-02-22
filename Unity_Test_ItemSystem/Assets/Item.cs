using UnityEngine;

public class Item : MonoBehaviour
{
    private MouseTarget mouseTarget;
    private bool follow;
    private ItemSystem itemSystem;

    private void Start()
    {
        mouseTarget = FindObjectOfType<MouseTarget>();
        itemSystem = FindObjectOfType<ItemSystem>();
    }

    private void Update()
    {
        ChooseItem();
    }

    private void ChooseItem()
    {
        if (Vector3.Distance(mouseTarget.transform.position, transform.position) < 10 && Input.GetKeyDown(KeyCode.Mouse0)) follow = true;

        if (follow)
        {
            transform.position = mouseTarget.transform.position;

            CheckItemEmpty();
        }
    }

    private void CheckItemEmpty()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            for (int i = 0; i < itemSystem.itemEmptys.Count; i++)
            {
                if (!itemSystem.itemEmptys[i].hasItem && Vector3.Distance(transform.position, itemSystem.itemEmptys[i].transform.position) < 10)
                {
                    itemSystem.itemEmptys[i].hasItem = true;
                    transform.position = itemSystem.itemEmptys[i].transform.position;
                    follow = false;
                }
            }
        }
    }
}
