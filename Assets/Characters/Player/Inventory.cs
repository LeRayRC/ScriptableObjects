using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{   
    [SerializeField]
    private List<ItemData> itemList_;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (!CollectItem()) Debug.Log("No objects found to collect!");
        }else if(Input.GetButtonDown("Fire2"))
        {
            DropItem();
        }
    }

    public bool CollectItem()
    {
        DataHolder dataHolderCollected_ = GameObject.FindObjectOfType<DataHolder>();
        if (dataHolderCollected_ == null) return false;
        itemList_.Add(dataHolderCollected_.itemInfo_);
        Destroy(dataHolderCollected_.gameObject);
        return true;
    }

    public bool DropItem()
    {
        int currentItems = itemList_.Count;
        if (currentItems <= 0) return false;
        GameObject goItemToDrop = itemList_[currentItems - 1].ItemPrefab_;
        float dropScale = itemList_[currentItems - 1].Scale_;
        GameObject go = GameObject.Instantiate<GameObject>(goItemToDrop);
        go.transform.localScale = new Vector3(dropScale, dropScale, dropScale);

        itemList_.Remove(itemList_[currentItems - 1]);
        return true;
    }
}
