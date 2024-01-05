using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extension
{
	public static class TransformExtension
	{
        /// <summary>
        /// Resets the position, rotation, and scale of the Transform to default values.
        /// </summary>
        /// <param name="transform">The Transform to reset.</param>
        public static void ResetTransform(this Transform transform)
        {
            transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// Finds and returns the first child Transform with the specified tag.
        /// </summary>
        /// <param name="parent">The parent Transform to search for a child with the specified tag.</param>
        /// <param name="tag">The tag to match against the child Transforms.</param>
        /// <returns>The first child Transform with the specified tag, or null if not found.</returns>
        public static Transform FindChildWithTag(this Transform parent, string tag)
        {
            Transform matchedChild = null;

            for (int i = 0; i < parent.childCount; i++)
            {
                if (parent.GetChild(i).CompareTag(tag))
                {
                    matchedChild = parent.GetChild(i);
                    break;
                }
            }

            return matchedChild;
        }

        /// <summary>
        /// Finds and returns the first active or inactive child Transform with the specified tag based on the provided parameter.
        /// </summary>
        /// <param name="parent">The parent Transform to search for a child with the specified tag and active state.</param>
        /// <param name="tag">The tag to match against the child Transforms.</param>
        /// <param name="shouldFindActive">Specify whether to find active or inactive child Transforms. Default is true (find active).</param>
        /// <returns>The first child Transform with the specified tag and active state, or null if not found.</returns>
        public static Transform FindActiveChildWithTag(this Transform parent, string tag, bool shouldFindActive = true)
        {
            Transform matchedChild = null;

            for (int i = 0; i < parent.childCount; i++)
            {
                Transform temp = parent.GetChild(i);
                if (temp.CompareTag(tag) && temp.gameObject.activeInHierarchy == shouldFindActive)
                {
                    matchedChild = parent.GetChild(i);
                    break;
                }
            }

            return matchedChild;
        }

        /// <summary>
        /// Finds and returns a list of child Transforms with the specified tag.
        /// </summary>
        /// <param name="parent">The parent Transform to search for child Transforms.</param>
        /// <param name="tag">The tag to match against the child Transforms.</param>
        /// <returns>A list of child Transforms with the specified tag.</returns>
        public static List<Transform> FindChildrenWithTag(this Transform parent, string tag)
        {
            List<Transform> matchedChildren = new();

            for (int i = 0; i < parent.childCount; i++)
            {
                if (parent.GetChild(i).CompareTag(tag))
                {
                    matchedChildren.Add(parent.GetChild(i));
                }
            }

            return matchedChildren;
        }

        /// <summary>
        /// Finds and returns a list of active child Transforms in the specified parent Transform with the given tag.
        /// </summary>
        /// <param name="parent">The parent Transform to search for active child Transforms.</param>
        /// <param name="tag">The tag to match against the child Transforms.</param>
        /// <param name="shouldFindActive">Specify whether to find active or inactive child Transforms. Default is true (find active).</param>
        /// <returns>A list of active child Transforms with the specified tag.</returns>
        public static List<Transform> FindActiveChildrenWithTag(this Transform parent, string tag, bool shouldFindActive = true)
        {
            List<Transform> matchedChildren = new();
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform temp = parent.GetChild(i);
                if (temp.CompareTag(tag) && temp.gameObject.activeInHierarchy == shouldFindActive)
                {
                    matchedChildren.Add(parent.GetChild(i));
                }
            }
            return matchedChildren;
        }
    }
}
