using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsmsQuiz.Models
{
    public class ServicePoint
    {

        public int ServicePointID { get; set; }
        public string ServicePointName { get; set; }

        public static string GetServicePointName(int servicePointId,Boolean isMobileCrmUser)
        {
            String servicePointName = "";
            using (var db = new WsmsQuizEntities())
            {
                String query = "";
                if (isMobileCrmUser)
                {
                    query =
                        String.Format("select ServicePointName from WSMS.dbo.ServicePoint where ServicePointID={0}",
                            servicePointId);
                   
                }
                else
                {
                    query =
                        String.Format("select ServicePointName from WaltonCrm.dbo.ServicePoint where ServicePointID={0}",
                            servicePointId);
                }
                servicePointName = db.Database.SqlQuery<String>(query).FirstOrDefault();
            }
            return servicePointName;
        }
    }
}