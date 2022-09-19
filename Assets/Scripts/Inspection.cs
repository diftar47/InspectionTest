using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inspection : MonoBehaviour
{
    [SerializeField] private Image evidence;
    [SerializeField] private Image item;
    [SerializeField] private Text description;

    private int currentItem = 0;
    private int index;
    private bool isFoundEvidence;
    private Sprite[] items;

    private void CheckIndex()
    {
        if (index == currentItem)
        {
            evidence.gameObject.SetActive(true);
        }
        else
        {
            evidence.gameObject.SetActive(false);
        }
        item.sprite = items[currentItem];
    }

    public void GoForward()
    {
        currentItem++;
        if (currentItem > items.Length - 1)
        {
            currentItem = 0;
        }
        CheckIndex();
    }

    public void GoBack()
    {
        currentItem--;
        if (currentItem > items.Length - 1 || currentItem < 0)
        {
            currentItem = items.Length - 1;
        }
        CheckIndex();
    }

    public void OnDescriptionClick()
    {
        description.gameObject.SetActive(true);
        isFoundEvidence = true;
    }

    public void Show(EvidenceExemple exemple)
    {
        description.gameObject.SetActive(false);
        description.text = "Вы нашли: " + exemple.description;

        index = exemple.evidenceIndex;
        evidence.gameObject.SetActive(false);

        evidence.sprite = exemple.evidanceImage;
        evidence.transform.position = exemple.evidencePosition;

        items = new Sprite[exemple.itemImages.Length];
        items = exemple.itemImages;
        CheckIndex();
    }
}

public class EvidenceExemple
{
    public Sprite[] itemImages;
    public Sprite evidanceImage;
    public int evidenceIndex;
    public string description;
    public Vector2 evidencePosition;
}
