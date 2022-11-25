using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        if(GM == null)
        {
            GM = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
    }

    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
