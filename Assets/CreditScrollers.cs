using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditScrollers : MonoBehaviour
{
    public float scrollSpeed = 30f; // Vitesse de d�filement
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // D�placer le texte vers le haut
        rectTransform.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);

        // Si le texte sort de l'�cran, vous pouvez le r�initialiser ou arr�ter le d�filement
        if (rectTransform.anchoredPosition.y > rectTransform.rect.height)
        {
            rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, -Screen.height);
        }
    }
}
