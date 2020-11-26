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

namespace RosSharp.RosBridgeClient.MessageTypes.Pr2Controllers
{
    public class Pr2GripperCommand : Message
    {
        public override string RosMessageName => "pr2_controllers_msgs/Pr2GripperCommand";
        public double position { get; set; }
        public double max_effort { get; set; }
        
        public Pr2GripperCommand()
        {
            this.position = 1.0;
            this.max_effort = 1.0;
        }

        public Pr2GripperCommand(double position, double max_effort)
        {
            this.position = position;
            this.max_effort = max_effort;
        }
    }
}