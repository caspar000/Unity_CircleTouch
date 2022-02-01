using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCircleAnim : MonoBehaviour
{
    [SerializeField]
    [Range(0f,1f)]
    float animOffset;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Animator>().SetFloat("animOffset", animOffset);
    }
}
