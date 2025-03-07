using UnityEngine;

namespace FlappyBird.Pause
{
    public abstract class Pausable : MonoBehaviour
    {
        public abstract void OnPause();
        public abstract void OnResume();
    }
}
