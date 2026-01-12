using UnityEngine;

public class SFXManager : MonoBehaviour
{
    //Objectif: Créér persistance de l'objet "SFX" dans les scènes suivantes
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
