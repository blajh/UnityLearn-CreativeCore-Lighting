using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressMe : MonoBehaviour
{
    [SerializeField] private GameObject referenceImage;

    public void PressMeButton() {
        referenceImage.SetActive(!referenceImage.activeSelf);
    }
}
