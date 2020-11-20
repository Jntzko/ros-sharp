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
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Jog
{
    public class JogFrameAbs : Message
    {
        public override string RosMessageName => "jog_msgs/JogFrameAbs";
        public Header header { get; set; }
        public string group_name { get; set; }
        public string link_name { get; set; }
        public bool avoid_collisions { get; set; }
        public Pose pose { get; set; }
        public double damping_factor { get; set; }

        public JogFrameAbs()
        {
            this.header = new Header();
            this.group_name = "";
            this.link_name = "";
            this.avoid_collisions = true;
            this.pose = new Pose();
            this.damping_factor = 1.0;
        }

        public JogFrameAbs(Header header, string group_name, string link_name, bool avoid_collision, Pose pose, double damping_factor)
        {
            this.header = header;
            this.group_name = group_name;
            this.link_name = link_name;
            this.avoid_collisions = avoid_collision;
            this.pose = pose;
            this.damping_factor = damping_factor;
        }
    }
}