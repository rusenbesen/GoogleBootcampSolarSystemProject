using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
   [SerializeField] ParticleSystem _particleSystem;

   private void OnCollisionEnter(Collision other) 
   {
        ParticleSystem.ShapeModule _editableShape = _particleSystem.shape;
        //_editableShape.rotation  = other.gameObject.GetComponent<Collider>().transform.rotation;
        _particleSystem.Play();
        Destroy(other.gameObject);
   }
}
