using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
abstract class GenericCardScript : MonoBehaviour
{
    public float speed;
    public Vector3 Target;
    public bool selecionado = false;
    public Image Front, Back;

    public abstract void Selecionado();

    public virtual void Retornar()
    {
        Target = new Vector3(0, 180, 0);
    }
    public virtual void Virar()
    {
        Target = new Vector3(0, 0, 0);
    }
}
