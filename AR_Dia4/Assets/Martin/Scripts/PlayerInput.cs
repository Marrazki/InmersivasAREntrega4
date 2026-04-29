using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PlayerInput : MonoBehaviour
{
    public ARPlaneManager planeManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            foreach (var plane in planeManager.trackables)
            {
                Destroy(plane.gameObject);
            }
        }
    }
}
