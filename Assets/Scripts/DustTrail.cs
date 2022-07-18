using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{

    [SerializeField] ParticleSystem dustBehindPlayer;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustBehindPlayer.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Invoke("StopDust", 0.5f); 
        }
    }

    void StopDust()
    {
        dustBehindPlayer.Stop();
    }

}
