﻿using UnityEngine;


public class Camera_follow : MonoBehaviour {
		public Transform target;
		public Vector3 offset; 

		void LateUpdate ()
		{

			transform.position = target.position + offset;
		}
	
	}
