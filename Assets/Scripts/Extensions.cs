using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

static public class MethodExtensionForMonoBehaviourTransform {
	/// <summary>
	/// Gets or add a component. Usage example:
	/// BoxCollider boxCollider = transform.GetOrAddComponent<BoxCollider>();
	/// </summary>
	static public T GetOrAddComponent<T> (this Component child) where T: Component {
		T result = child.GetComponent<T>();
		if (result == null) {
			result = child.gameObject.AddComponent<T>();
		}
		return result;
	}

     public static T PickRandom<T>(this IEnumerable<T> source)
    {
        return source.PickRandom(1).Single();
    }

    public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
    {
        return source.Shuffle().Take(count);
    }

    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
    {
        return source.OrderBy(x => Guid.NewGuid());
    }
}
static class TransformExtensions
{
	 public static void SetXPos(this Transform t, float newXPos) {
        var pos = t.position;
        pos.x = newXPos;
        t.position = pos;
    }
	 public static void SetYPos(this Transform t, float newYPos) {
        var pos = t.position;
        pos.y = newYPos;
        t.position = pos;
    }
	 public static void SetZPos(this Transform t, float newZPos) {
        var pos = t.position;
        pos.z = newZPos;
        t.position = pos;
    }

	 public static void SetXScale(this Transform t, float newXScale) {
        var scale = t.localScale;
        scale.x = newXScale;
        t.localScale = scale;
    }
	 public static void SetYScale(this Transform t, float newYScale) {
        var scale = t.localScale;
        scale.y = newYScale;
        t.localScale = scale;
    }
	 public static void SetZScale(this Transform t, float newZScale) {
        var scale = t.localScale;
        scale.z = newZScale;
        t.localScale = scale;
    }
}