using System;
using UnityEngine;

namespace UnityAD
{
	[Serializable]
	public struct BallisticTrajectoryInfo
	{		
		public float gravity;
		public float launchAngle;
		public float launchForce;
		public float projectileMass;
		public float InitialVelocity { get { return launchForce/projectileMass; } }
	}

	public static class RigidBodyToolMethods
	{
		public static Vector2[] CalculateBallisticTrajectory(BallisticTrajectoryInfo ballisticTrajectoryInfo, int totalPredictions, float predictionInterval)
		{
			Vector2[] positions = new Vector2[totalPredictions];
			float initialVelocity = ballisticTrajectoryInfo.InitialVelocity;
			float time = 0;
			for(int i = 0; i < totalPredictions; i++)
			{
				time += predictionInterval;
				float horizontalDisplacement = initialVelocity * time*(float)Math.Cos(ballisticTrajectoryInfo.launchAngle*Mathf.Deg2Rad);
				float verticalDisplacement = initialVelocity * time *(float)Math.Sin(ballisticTrajectoryInfo.launchAngle*Mathf.Deg2Rad) - 0.5f*ballisticTrajectoryInfo.gravity*time*time;
				Vector2 predictedPosition = new Vector2(horizontalDisplacement, verticalDisplacement);
				positions[i] = predictedPosition;
			}
			return positions;
		}
	}
}

