using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInfo : MonoBehaviour
{
    Player player;

    GameObject characterPanel;


    public void Open()
    {
        //AllMenus menus = new AllMenus();
        //menus.Close();
        gameObject.SetActive(true);
    }

    public void Start()
    {
        characterPanel = transform.FindChild("Character Panel").gameObject;

        player = GameObject.Find("Player").GetComponent<Player>();

        setupInvPanel();
    }

    public void Update()
    {
        setStatsPanel();
    }

    void setStatsPanel()
    {
        GameObject statsPanel = characterPanel.transform.FindChild("Stat Data").gameObject;
        GameObject text = statsPanel.transform.FindChild("Text").gameObject;
        Text txt = text.GetComponent<Text>();
        txt.text = player.Status();
    }


    GameObject createPanel(int num)
    {
        GameObject panel = new GameObject();
        panel.AddComponent<CanvasRenderer>();
        panel.AddComponent<RectTransform>();
        panel.AddComponent<Image>();

        panel.name = "Slot " + num;
        return panel;
    }

    void setupInvPanel()
    {
        int counter = 0;
        for (int x = 0; x < player.inv.Length; x++)
        {
            GameObject invPanel = transform.FindChild("Inv Panel").gameObject;
            GameObject slot = createPanel(x);

            RectTransform rec = slot.GetComponent<RectTransform>();
            rec.sizeDelta = new Vector2(56, 56);

            int row = (int)x / 8;
            if (counter >= 8)
            {
                counter = 0;
            }
            int xAdd = 56 * counter;
            int yAdd = -56 * row - 4;

            int xCor = (int)(644.5f - 204.5f + (xAdd) + (2*counter));
            int yCor = 185 + 70 + (yAdd) - (2*row);
            //slot.transform.parent = invPanel.transform; //Works too but prefers the other one
            slot.transform.SetParent(invPanel.transform);

            Debug.Log(slot.name + " " + xCor);
            Debug.Log(counter);
            rec.position = new Vector3(xCor+ 4, yCor - 4, 0);
            //rec.position = new Vector3(0, 0, 0);
            //rec.position = new Vector3(-204, 70, 0);
            //counter++;

            Image im = slot.GetComponent<Image>();
            if(isOdd(x))
            {
                im.color = Color.blue;
            }
            else
            {
                im.color = Color.green;
            }

            im.sprite = Resources.Load<Sprite> ("Texture/default_slot.png") as Sprite;
            //im.sprite = new Sprite("Texture/default_slot");

            counter = counter + 1;
        }
    }

    bool isOdd(int value)
    {
        return value % 2 != 0;
    } 
}
