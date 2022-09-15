using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inspection : MonoBehaviour
{
    [SerializeField] Image evidence;
    [SerializeField] Image item;

    private int currentItem = 0;
    private Image[] items;

    private void GoForward()
    {
        currentItem++;
        if(currentItem > items.Length - 1)
        {
            currentItem = 0;
        }
        item = items[currentItem];
    }

    public void Show(EvidenceExemple exemple)
    {
        evidence.gameObject.SetActive(false);
        evidence.transform.position = exemple.evidencePosition;
        evidence = exemple.evidanceImage;
        if (exemple.evidenceIndex == currentItem)
        {
            evidence.gameObject.SetActive(true);
        }

        items = new Image[exemple.itemImages.Length];
        items = exemple.itemImages;
        item = items[currentItem];
    }
}

public class EvidenceExemple
{
    public Image []itemImages;
    public Image evidanceImage;
    public int evidenceIndex;
    public string description;
    public Vector2 evidencePosition;
}
