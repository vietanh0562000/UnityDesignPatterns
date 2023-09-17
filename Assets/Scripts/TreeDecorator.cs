using UnityEngine;

namespace DefaultNamespace
{
    public abstract class TreeDecorator : MonoBehaviour, IDecorTree
    {
        private NormalTree _wrappedNormalTree;
        
        public void SetWrappedTree(NormalTree normalTree)
        {
            _wrappedNormalTree = normalTree;
        }

        public virtual NormalTree GetDecorTree()
        {
            return _wrappedNormalTree.GetDecorTree();
        }
    }
}