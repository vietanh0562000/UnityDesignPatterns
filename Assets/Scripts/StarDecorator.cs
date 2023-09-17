using UnityEngine;

namespace DefaultNamespace
{
    public class StarDecorator : TreeDecorator
    {
        [SerializeField] private GameObject _star;

        public override NormalTree GetDecorTree()
        {
            var tree = base.GetDecorTree();
            var starPlace = tree.GetStarPlace();
            Instantiate(_star, starPlace.position, Quaternion.identity, tree.transform);
            return tree;
        }
    }
}