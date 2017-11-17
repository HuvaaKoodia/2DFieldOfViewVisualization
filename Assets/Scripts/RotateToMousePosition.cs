using UnityEngine;
using System.Collections.Generic;

public class RotateToMousePosition : MonoBehaviour 
{
#region variables
#endregion
#region initialization
#endregion
#region update logic
	private void Update () 
	{
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.rotation = Quaternion.LookRotation(Vector3.forward, (mouseWorldPosition - transform.position).normalized);
	}
#endregion
#region public interface
#endregion
#region private interface
#endregion
#region events
#endregion
}
