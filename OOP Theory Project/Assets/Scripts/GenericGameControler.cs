using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

abstract class GenericGameControler : MonoBehaviour
{
    public GameObject TelaFinal;

    public virtual void Ganhou()
    {
        TelaFinal.SetActive(true);
        TelaFinal.GetComponentInChildren<TextMeshProUGUI>().text = "Vitoria";
    }
    public virtual void Perdeu()
    {
        TelaFinal.SetActive(true);
        TelaFinal.GetComponentInChildren<TextMeshProUGUI>().text = "Derrota";
    }
}
