using UnityEngine;

namespace DefaultNamespace
{
    public class LifeTimer : MonoBehaviour
    {
        [SerializeField] private float lifeTime;


        private void Update()
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0)
            {
                
                Destroy(gameObject);
            }
            
        }
    }
}