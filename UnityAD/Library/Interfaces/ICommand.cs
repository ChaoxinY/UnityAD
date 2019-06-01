using UnityEngine;

namespace UnityAD
{
    public interface ICommand
    {
        void Execute(GameObject actor);
    }
}
