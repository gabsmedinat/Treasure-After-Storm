using UnityEngine;

public class SFXHandler : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1;



    public void PlaySFX1()
    {
        src.clip = sfx1;
        src.Play();

    }

    //public void PlaySFX2()
    //{
    //    src.clip = sfx2;
    //    src.Play();
    //}
}
