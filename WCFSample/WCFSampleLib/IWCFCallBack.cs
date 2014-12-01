using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFSampleLib
{
    [ServiceContract]
    public interface IWCFCallBack
    {
        [OperationContract]
        void ReplyFromServer(string messge);
    }

    [ServiceContract(CallbackContract = typeof(IWCFCallBack),
        SessionMode = SessionMode.Required)]
    public interface IWCFCallBackService
    {
        [OperationContract]
        Course[] GetAllCources();
        [OperationContract]
        void AddPerson(Person person);
        [OperationContract]
        void UpdatePerson(int personID,Person person);
        [OperationContract]
        void DeletePerson(int personID);
    }

    [DataContract(Namespace = "WCFSampleLib.Course")]
    public class Course
    {
        [DataMember]
        public int CourseID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int Credits { get; set; }
        [DataMember]
        public string URL { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Days { get; set; }
        [DataMember]
        public System.DateTime? Time { get; set; }
    }
}
