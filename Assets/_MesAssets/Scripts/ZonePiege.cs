using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listePieges = default;
    [SerializeField] private float _intensiteForce = 500f;

    private List<Rigidbody> _listeRb = new List<Rigidbody>();

    private void Awake()
    {
        foreach(var piege in _listePieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
            piege.GetComponent<Rigidbody>().useGravity = false;
        }
    }
    private void Start()
    {
 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            foreach(var rb in _listeRb)
            {
                rb.useGravity = true;
                rb.AddForce(Vector3.down * _intensiteForce);
            }
        } 
    }
}
