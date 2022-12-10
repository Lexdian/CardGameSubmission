using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

class BattleCardObj : GenericCardScript
{
    public Image Tras;
    public CardSO CardInfo;
    public float CurrentNum;
    public TextMeshProUGUI Numero;
    float Num
    {
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

    public override void Selecionado()
    {
        throw new System.NotImplementedException();
    }
    private void OnEnable()
    {
        Num = CardInfo.Num;
        Numero.text = CurrentNum.ToString();
    }
    private void OnDisable()
    {
        Retornar();
        transform.rotation = Quaternion.Euler(Vector3.zero);
    }
    private void FixedUpdate()
    {
        if(transform.rotation.eulerAngles != Target)
        {
            transform.Rotate(new Vector3(0, 1, 0) * speed);
        }
        if(transform.rotation.eulerAngles.y - Target.y < 5)
        {
            transform.rotation = Quaternion.Euler(Target);
        }
    }
}
