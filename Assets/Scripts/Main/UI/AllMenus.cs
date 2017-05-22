using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllMenus : MonoBehaviour
{

	public void Close()
    {
        GameObject characterInfo = transform.FindChild("Character Info").gameObject;
        GameObject itemBox = transform.FindChild("Item Box").gameObject;
        GameObject equipment = transform.FindChild("Equipment").gameObject;

        characterInfo.SetActive(false);
        itemBox.SetActive(false);
        equipment.SetActive(false);
    }
}
