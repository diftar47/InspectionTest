using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectionController : MonoBehaviour
{
    private EvidenceExemple evidenceExemple;
    private Inspection inspection;

    [SerializeField] private Sprite[] itemImagesExemple = new Sprite[2];
    [SerializeField] private Sprite evidenceImageExemple;
    [SerializeField] private string descriptionExemple = "отпечаток пальца";
    [SerializeField] private Vector2 evidencePosition = new Vector2(-10, 20);
    [SerializeField] private int indexExemple = 0;

    private void Awake()
    {
        Vector2 position = new Vector2(461.5f, 294.5f) + evidencePosition;
        evidenceExemple = new EvidenceExemple();
        inspection = gameObject.GetComponent<Inspection>();

        evidenceExemple.evidanceImage = evidenceImageExemple;
        evidenceExemple.evidenceIndex = indexExemple;
        evidenceExemple.itemImages = itemImagesExemple;
        evidenceExemple.description = descriptionExemple;
        evidenceExemple.evidencePosition = position;

        inspection.Show(evidenceExemple);
    }
}
