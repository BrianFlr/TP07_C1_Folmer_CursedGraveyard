using System.Collections.Generic;
using UnityEngine;

public class DaggerObjectPool : MonoBehaviour
{
    [Header ("Pool Container")]
    [SerializeField] Transform daggerPoolContainer;

    [Header("Pool Prefab")]
    [SerializeField] GameObject daggerPrefab;

    private float minimumAmount = 8f;

    // Creo una lista de GameObjects
    private List<GameObject> daggerPool = new List<GameObject>();

    void Start()
    {
        // Creo los objetos del pool
        for (int i = 0; i < minimumAmount; i++)
        {
            CreateNewObjectDagger();
        }
    }

    // Funcion para instanciar la daga en el object pool
    GameObject CreateNewObjectDagger()
    {
        // Instancio el prefab de la daga y lo guardo en el objeto padre que lo contendra
        GameObject obj = Instantiate(daggerPrefab, daggerPoolContainer);

        // Añado el objeto creado a la lista
        daggerPool.Add(obj);

        // Desactivo el objeto
        obj.SetActive(false);

        // Devuelvo el objeto
        return obj;
    }

    // Funcion para utilizar los objetos daga creados en la pool
    public GameObject GetObjectDagger()
    {
        // Busco un objeto desactivado de la lista
        GameObject obj = daggerPool.Find(x => x.activeSelf == false);

        // Si todos los objetos se encuentran activos y por lo tanto devolveria null
        if (obj == null)
        {
            // Creo un nuevo objeto
            CreateNewObjectDagger();
        }

        // Activo el objeto seleccionado de la lista
        obj.SetActive(true);

        // Devuelvo el objeto
        return obj;
    }
}
