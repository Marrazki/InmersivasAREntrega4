using UnityEngine;

public class Borrador : MonoBehaviour
{
    public GameObject[] objetos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Borrar()
    {
        GameObject cube = GameObject.Find("Cube(Clone)");
        if (cube != null)
        {
            Destroy(cube);
        }
    }

    public void CambiarObjeto(int index)
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(i == index);
        }
    }
}
