using UnityEngine;

namespace DefaultNamespace
{
    public class NormalTree : MonoBehaviour, IDecorTree
    {
        [SerializeField] private GameObject _baseTree;
        [SerializeField] private Transform _starPlace;
        
        public NormalTree GetDecorTree()
        {
            return this;
        }

        public Transform GetStarPlace()
        {
            return _starPlace;
        }
    }
}