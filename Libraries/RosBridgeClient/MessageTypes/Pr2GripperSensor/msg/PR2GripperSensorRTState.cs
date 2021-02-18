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
    public class Pr2GripperSensorRTState : Message
    {
        public override string RosMessageName => "pr2_gripper_sensor_msgs/Pr2GripperSensorRTState";

        public const uint DISABLED = 0;
        public const uint POSITION_SERVO = 3;
        public const uint FORCE_SERVO = 4;
        public const uint FIND_CONTACT = 5;
        public const uint SLIP_SERVO = 6;
        public uint realtime_controller_state;

        public Pr2GripperSensorRTState()
        {
            this.realtime_controller_state = 0;
        }

        public Pr2GripperSensorRTState(uint realtime_controller_state)
        {
            this.realtime_controller_state = realtime_controller_state;
        }
    }
}