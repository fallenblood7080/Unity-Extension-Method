using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extension.Example
{
    public class Physic2DExtensionExample : MonoBehaviour
    {
        [SerializeField] private float explosionRange, explosionPwr;
        private void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                Vector2 explosionPoint = Input.mousePosition.ScreenToWorldPoint(Camera.main);
                explosionPoint.Add2DExplosiveForce(explosionRange, explosionPwr);
            }

        }
    } 
}
