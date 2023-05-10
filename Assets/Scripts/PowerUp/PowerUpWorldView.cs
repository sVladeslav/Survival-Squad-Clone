using UnityEngine;

namespace UnityTemplateProjects.PowerUp
{
    public class PowerUpWorldView: MonoBehaviour
    {
        protected IPowerUp _powerUp;

        public virtual IPowerUp PowerUp => _powerUp;
    }
}