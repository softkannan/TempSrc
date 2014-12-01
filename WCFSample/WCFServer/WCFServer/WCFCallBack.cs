using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFSampleLib;

namespace WCFServer
{
    [ServiceBehavior(AutomaticSessionShutdown = true, 
        ConcurrencyMode = ConcurrencyMode.Multiple , 
        InstanceContextMode = InstanceContextMode.PerSession)]
    public class WCFCallBackServiceImpl : IWCFCallBackService
    {
        public WCFCallBackServiceImpl()
        {
            LogSQL("Session Created.");

            OperationContext.Current.InstanceContext.Closing += InstanceContext_Closing;
            
        }

        void InstanceContext_Closing(object sender, EventArgs e)
        {
            LogSQL("Session Completed.");
        }
        private void LogSQL(string sqlData)
        {
            MainWindow.LogMsg(sqlData);
        }
        
        public WCFSampleLib.Course[] GetAllCources()
        {
            using(SchoolEntities db = new SchoolEntities())
            {
                db.Database.Log = LogSQL;

                var retVal = new List<WCFSampleLib.Course>();

                retVal.AddRange(from t in db.Courses
                                join t1 in db.OnlineCourses on t.CourseID equals t1.CourseID
                                select new WCFSampleLib.Course() { CourseID = t.CourseID, Credits = t.Credits, Title = t.Title, URL = t1.URL });

                retVal.AddRange(from t in db.Courses
                                join t2 in db.OnsiteCourses on t.CourseID equals t2.CourseID
                                select new WCFSampleLib.Course() { CourseID = t.CourseID, Credits = t.Credits, Days = t2.Days, Location = t2.Location, Time = t2.Time, Title = t.Title });

                return retVal.ToArray();
            }
        }

        public void AddPerson(WCFSampleLib.Person person)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int personID, WCFSampleLib.Person person)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int personID)
        {
            throw new NotImplementedException();
        }
    }
}
