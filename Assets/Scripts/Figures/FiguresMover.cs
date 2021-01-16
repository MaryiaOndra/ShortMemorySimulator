using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiguresMover : MonoBehaviour
{
    [SerializeField] private GameObject[] usedPrefabs;
    [SerializeField] private Material material;

    private UsedFigure[] workPrefabs;
    int randomNumbr;

    private void Awake()
    {
        for (int i = 0; i < usedPrefabs.Length; i++)
        {
            GameObject.Instantiate(usedPrefabs[i], transform).SetActive(false);
        }

        workPrefabs = GetComponentsInChildren<UsedFigure>(true);
    }

    private void Start()
    {
        SetRandomPrefab();
    }

    public void SetRandomPrefab() 
    {
        randomNumbr = Random.Range(0, usedPrefabs.Length);
        workPrefabs[randomNumbr].Activate();
    }
    
    private void SetRandomColor() 
    {
    
    }

    private void SetRandomRotation() 
    {
    
    }

    public void Answer() 
    {
        workPrefabs[randomNumbr].DropDown();
    }
}
