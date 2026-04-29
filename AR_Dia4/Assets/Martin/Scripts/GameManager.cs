using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class GameManager : MonoBehaviour
{
    public int numeroPlanos;
    public ARPlaneManager planeManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        numeroPlanos = planeManager.trackables.count;
    }
}
