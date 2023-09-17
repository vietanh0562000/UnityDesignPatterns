using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Serialization;
using Tree = UnityEngine.Tree;

public class TreeCompany : MonoBehaviour
{
    [SerializeField] private NormalTree _treePrefab;
    [SerializeField] private StarDecorator _starDecorator;

    private NormalTree _normalTree;

    // Start is called before the first frame update
    void Start()
    {
        _normalTree = Instantiate(_treePrefab).GetComponent<NormalTree>();
        _starDecorator.SetWrappedTree(_normalTree);
        _normalTree = _starDecorator.GetDecorTree();
    }

    // Update is called once per frame
    void Update()
    {
    }
}