using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class thBtn : MonoBehaviour
{

    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "3STBTN":
                SceneManager.LoadScene("3ST");
                break;
        }
    }
}
