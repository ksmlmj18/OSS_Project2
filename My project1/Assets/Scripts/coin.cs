using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.coinAmount += 1;
        Destroy(gameObject);
        Sfx.SoundPlay();
    }
}