using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditScrollers : MonoBehaviour
{
    public float scrollSpeed = 30f; // Vitesse de défilement
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // Déplacer le texte vers le haut
        rectTransform.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);

        // Si le texte sort de l'écran, vous pouvez le réinitialiser ou arrêter le défilement
        if (rectTransform.anchoredPosition.y > rectTransform.rect.height)
        {
            rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, -Screen.height);
        }
    }
}
