using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

class BattleCard : GenericCardScript
{
    public CardSO CardInfo;
    private float CurrentNum;

    public TextMeshProUGUI Numero;

    public override void Selecionado()
    {
        if(selecionado == false) 
        {
            Debug.Log("Nahida");
            selecionado = true;
        }
    }
    float Num {
        set
        {
            if (value < 0)
            {
                CurrentNum = 0;
            }
            else
            {
                CurrentNum = value;
            }
        }
        }
    private Image Img;
    void Awake()
    {
        Num = CardInfo.Num;
        Img = CardInfo.img;

        Numero.text = CurrentNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
