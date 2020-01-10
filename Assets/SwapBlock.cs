using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapBlock : MonoBehaviour
{
    private List<GameObject> swapBlockA = new List<GameObject>();
    private List<GameObject> swapBlockB = new List<GameObject>();
    public GameObject EffectA;
    public GameObject EffectB;

    public bool hasPowerA;
    public bool hasPowerB;
    public string Color;

    // Start is called before the first frame update
    void Awake()
    {
        /*for(int i = 0; i < swapBlockA.Count; i++) {
            meshRendererA[i] = swapBlockA[i].GetComponent<MeshRenderer>();
            collA[i] = swapBlockA[i].GetComponent<Collider>();
            
            meshRendererA[i].enabled = hasPowerA;
            collA[i].enabled = hasPowerA;
        }
        for(int i = 0; i < swapBlockB.Count; i++) {
            meshRendererB[i] = swapBlockB[i].GetComponent<MeshRenderer>();
            collB[i] = swapBlockB[i].GetComponent<Collider>();
            
            meshRendererB[i].enabled = hasPowerB;
            collB[i].enabled = hasPowerB;
        }*/

    }

    public void Swap() {
        Vector3 posA = EffectA.transform.position;
        EffectA.transform.position = EffectB.transform.position;
        EffectB.transform.position = posA;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SwapBlock") {

        }
    }
}