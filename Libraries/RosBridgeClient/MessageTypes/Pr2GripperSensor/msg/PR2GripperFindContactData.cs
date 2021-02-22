/*
© Siemens AG, 2017-2018
Author: Dr. Martin Bischoff (martin.bischoff@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Pr2GripperSensor
{
    public class PR2GripperFindContactData : Message
    {
        public override string RosMessageName => "pr2_gripper_sensor_msgs/PR2GripperFindContactData";


        public Time stamp { get; set; }
        public bool contact_conditions_met { get; set; }
        public bool left_fingertip_pad_contact { get; set; }
        public bool right_fingertip_pad_contact { get; set; }
        public double left_fingertip_pad_force { get; set; }
        public double right_fingertip_pad_force { get; set; }
        public double joint_position { get; set; }
        public double joint_effort { get; set; }
        Pr2GripperSensorRTState rtstate { get; set; }

        public PR2GripperFindContactData()
        {
            this.stamp = new Time();
            this.contact_conditions_met = false;
            this.left_fingertip_pad_contact = false;
            this.right_fingertip_pad_contact = false;
            this.left_fingertip_pad_force = 0.0;
            this.right_fingertip_pad_force = 0.0;
            this.joint_position = 0.0;
            this.joint_effort = 0.0;
        }

        public PR2GripperFindContactData(Time stamp, bool contact_conditions_met, bool left_fingertip_pad_contact, bool right_fingertip_pad_contact, double left_fingertip_pad_force, double right_fingertip_pad_force, double joint_position, double joint_effort, Pr2GripperSensorRTState rtstate)
        {
            this.stamp = stamp;
            this.contact_conditions_met = contact_conditions_met;
            this.left_fingertip_pad_contact = left_fingertip_pad_contact;
            this.right_fingertip_pad_contact = right_fingertip_pad_contact;
            this.left_fingertip_pad_force = left_fingertip_pad_force;
            this.right_fingertip_pad_force = right_fingertip_pad_force;
            this.joint_position = joint_position;
            this.joint_effort = joint_effort;
        }
    }
}