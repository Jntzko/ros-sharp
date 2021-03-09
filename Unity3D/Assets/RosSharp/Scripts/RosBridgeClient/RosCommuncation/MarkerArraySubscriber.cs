﻿/*
© Universität Hamburg, 2021
Author: Yannick Jonetzko (jonetzko@informatik.uni-hamburg.de)

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

namespace RosSharp.RosBridgeClient
{
    public class MarkerArraySubscriber : UnitySubscriber<MessageTypes.Visualization.MarkerArray>
    {
        private MarkerArrayWriter markerArrayWriter;

        protected override void Start()
        {
            markerArrayWriter = gameObject.AddComponent<MarkerArrayWriter>();
            base.Start();
        }

        protected override void ReceiveMessage(MessageTypes.Visualization.MarkerArray message)
        {
            markerArrayWriter.Write(message);
        }

        private void OnEnable()
        {
            if (markerArrayWriter)
                markerArrayWriter.enabled = true;
        }

        private void OnDisable()
        {
            markerArrayWriter.enabled = false;
        }
    }
}