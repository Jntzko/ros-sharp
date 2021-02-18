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

namespace RosSharp.RosBridgeClient.MessageTypes.TamsUnityUtils
{
    public class SubstitutionMode : Message
    {
        public override string RosMessageName => "tams_unity_utils/SubstitutionMode";
        public int goal_pose { get; set; }
        public bool tactile_arrows { get; set; }
        public bool tactile_text { get; set; }
        public bool tactile_colored_ball { get; set; }
        public bool audio { get; set; }
        public bool mirrored { get; set; }
        public bool enable_teleop { get; set; }
        public bool inspector_mode { get; set; }

        public SubstitutionMode()
        {
            goal_pose = 2;
            tactile_arrows = false;
            tactile_text = false;
            tactile_colored_ball = false;
            audio = false;
            mirrored = false;
            enable_teleop = false;
            inspector_mode = false;
        }

        public SubstitutionMode(int goal_pose, bool tactile_arrows, bool tactile_text, bool tactile_colored_ball, bool audio, bool mirrored, bool inspector_mode)
        {
            this.goal_pose = goal_pose;
            this.tactile_arrows = tactile_arrows;
            this.tactile_text = tactile_text;
            this.tactile_colored_ball = tactile_colored_ball;
            this.audio = audio;
            this.mirrored = mirrored;
            this.inspector_mode = inspector_mode;
        }
    }
}