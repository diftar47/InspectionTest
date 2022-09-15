using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectionController : MonoBehaviour
{
    private EvidenceExemple evidenceExemple;
    private Inspection inspection;

    [SerializeField] private Image []itemImagesExemple = new Image[1];
    [SerializeField] private Image evidenceImageExemple;
    [SerializeField] private string descriptionExemple = "Отпечаток пальца";
    [SerializeField] private int indexExemple = 0;

    private void Awake()
    {
        evidenceExemple = new();
        inspection = new();

        evidenceExemple.evidanceImage = evidenceImageExemple;
        evidenceExemple.evidenceIndex = indexExemple;
        evidenceExemple.itemImages = itemImagesExemple;
        evidenceExemple.description = descriptionExemple;
        evidenceExemple.evidencePosition = new Vector2(-79, -35);

        inspection.Show(evidenceExemple);
    }
}
