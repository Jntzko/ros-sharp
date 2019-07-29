/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.FileServer
{
    public class FileTransferFromRosAction : Action<FileTransferFromRosActionGoal, FileTransferFromRosActionResult, FileTransferFromRosActionFeedback, FileTransferFromRosGoal, FileTransferFromRosResult, FileTransferFromRosFeedback>
    {
        [JsonIgnore]
        public const string RosMessageName = "file_server/FileTransferFromRosAction";

        public FileTransferFromRosAction() : base()
        {
            this.action_goal = new FileTransferFromRosActionGoal();
            this.action_result = new FileTransferFromRosActionResult();
            this.action_feedback = new FileTransferFromRosActionFeedback();
        }

    }
}