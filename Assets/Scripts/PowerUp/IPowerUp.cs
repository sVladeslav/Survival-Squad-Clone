using System;

namespace UnityTemplateProjects.PowerUp
{
    public interface IPowerUp
    {
        public IPowerUpValue PowerUpValue { get;}
        public IPowerable Powerable { get; }
        public event Action OnDeactivated;

        public void Initialize(IPowerUpValue powerUpValue, IPowerable powerable);

        public void Activate(Action onActivated);
    }
}