using UnityEngine;
using UnityEditor;
using System.Collections;
 
public class PlacementHelpers : ScriptableObject
{
    [MenuItem ("Custom/Placement Helpers %g")] //%g inside the string would bind this to the hotkey ctrl+g
	static void SnapEmptyGameObject ()
	{
		//get transforms of gameobject that empty gameobject will be snapped to
		Transform selectedGOtransforms = Selection.activeTransform;
		Vector3 selectedGOposition = selectedGOtransforms.transform.position;
		Quaternion selectedGOrotations = selectedGOtransforms.transform.rotation;
		
		
		//create the empty gameobject that will be snapped to the position
		GameObject snappedGameObject = new GameObject("snappedGameObject");
		
		//transfer transforms from selected gameobect to empty gameobect
		snappedGameObject.transform.position = selectedGOposition;
		snappedGameObject.transform.rotation = selectedGOrotations;
		
		// to do: implement undo
		
		
		
		
		
		
		
	}
	
	[MenuItem ("Custom/Another Placement Helper")]
	static void snapAnotherGameObject ()
	{
		Debug.Log(Selection.gameObjects.Length);
	}
}