﻿/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.AprilTagRos
{
    public class AprilTagDetection : Message
    {
        public override string RosMessageName => "apriltag_ros/AprilTagDetection";

        public int[] id { get; set; }
        public double[] size { get; set; }
        public PoseWithCovarianceStamped pose { get; set; }

        public AprilTagDetection()
        {
            this.id = new int[0];
            this.size = new double[0];
            this.pose = new PoseWithCovarianceStamped();
        }

        public AprilTagDetection(int[] id, double[] size, PoseWithCovarianceStamped pose)
        {
            this.id = id;
            this.size = size;
            this.pose = pose;
        }
    }
}