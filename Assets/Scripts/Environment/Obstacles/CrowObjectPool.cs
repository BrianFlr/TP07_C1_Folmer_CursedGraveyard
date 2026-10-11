using System.Collections.Generic;
using UnityEngine;

public class CrowObjectPool : MonoBehaviour
{
    [Header ("Pool Container")]
    [SerializeField] Transform crowPoolContainer;

    [Header("Pool Prefab")]
    [SerializeField] GameObject crowPrefab;

    [SerializeField] private float minimumAmount = 5f;

    // Creo una lista de GameObjects
    private List<GameObject> crowPool = new List<GameObject>();

    void Start()
    {
        // Creo los objetos de cada pool
        for (int i = 0; i < minimumAmount; i++)
        {
            CreateNewObjectCrow();
        }
    }

    // Funciones para instanciar cada obtáculo en cada lista de pool
    GameObject CreateNewObjectCrow()
    {
        // Instancio el prefab del cuervo y lo guardo en su respectivo objeto padre
        GameObject obj = Instantiate(crowPrefab, crowPoolContainer);

        // Añado el objeto creado a la lista
        crowPool.Add(obj);

        // Desactivo el objeto
        obj.SetActive(false);

        // Devuelvo el objeto
        return obj;
    }

    // Funciones para utilizar los objetos creados en las pools
    public GameObject GetObjectCrow()
    {
        // Busco en mi lista un objeto desactivado de la lista (Del pool)
        GameObject obj = crowPool.Find(x => x.activeSelf == false);

        // Si todos los objetos se encuentran activos y por lo tanto devolveria null
        if (obj == null)
        {
            // Creo un nuevo objeto
            CreateNewObjectCrow();
        }

        // Activo el objeto seleccionado de la lista (Del pool)
        obj.SetActive(true);

        // Devuelvo el objeto
        return obj;
    }
}
