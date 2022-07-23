using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
   [SerializeField] ParticleSystem _particleSystem;

   private void OnCollisionEnter(Collision other) 
   {
        ParticleSystem.ShapeModule _editableShape = _particleSystem.shape;
        //_editableShape.position  = other.gameObject.GetComponent<Collider>().transform.position;
        _particleSystem.Play();
        Destroy(other.gameObject);
   }
}
