using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using incentive_policy.ViewModel;
using log4net;
/*Table
                          
    CREATE TABLE [dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Thread] [varchar](5000) NOT NULL,
	[Level] [varchar](5000) NOT NULL,
	[Logger] [varchar](5000) NOT NULL,
	[Message] [varchar](5000) NOT NULL,
	[Exception] [varchar](5000) NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
             */

//Transcation
/*
  using (SqlTransaction tran = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        // your code
                        SqlCommand sqlCommand = new SqlCommand("insert into xyzs(akash) values('aammamamamam')",sqlConnection,tran);
                        sqlCommand.ExecuteNonQuery();
                        tran.Commit();
                        logger.Info("Successfully done");
                    }
                    catch (Exception e)
                    {
                        tran.Rollback();
                        logger.Fatal("Dont know",e);
                        throw;
                    }
                }
 */
using SendMail;

namespace incentive_policy
{
    class Program
    {
        private static readonly ILog logger =
           LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            logger.Info("Application Started");
            string fromTime = DateTime.Now.ToString("yyyy-MM-dd");
            string toTime =
                Convert.ToDateTime(
                    Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"))
                        .AddHours(23)
                        .AddMinutes(59)
                        .AddSeconds(59)).ToString("yyyy-MM-dd HH:mm:ss");
         //  fromTime = "2016-04-01";
          // toTime = "2016-04-01 23:59:59";

            using (
                        var sqlConnection =
                            new SqlConnection(
                                ConfigurationManager.ConnectionStrings["WSMSConectionString"].ConnectionString)
                        )
            {
                sqlConnection.Open();
                
               
                using (SqlTransaction tran = sqlConnection.BeginTransaction())
                {
                    
                    try
                    {
                        long incentiveDistributionPercentageID = Distribution.GetMaxDistribution(sqlConnection,tran);
                        long incentiveLimitID = Limits.GetMaxLimitId(sqlConnection,tran);
                        long incentiveRateID = Rate.GetMaxRate(sqlConnection,tran);
                        long penaltyDay = Limits.GetpenaltydayLimit(incentiveLimitID, sqlConnection,tran);
                        List<int> servicePointIds = ServicePoints.GetServicePointsId(sqlConnection,tran);
                        foreach (var servicePointId in servicePointIds)
                        {
                           
                            long incentive_master_id = IncentiveMaster.InsertIntoMasterTable(servicePointId,
                                incentiveDistributionPercentageID, incentiveLimitID, incentiveRateID, fromTime,
                                sqlConnection, tran);
                            //final OK Checked
                              Receiver.CalculateReceiverAmmount(servicePointId, fromTime, toTime, sqlConnection, incentive_master_id, tran);
                            //final OK Checked
                             Technician.CalculateTechnicianAmmount(servicePointId, fromTime, toTime, sqlConnection, incentive_master_id, tran);
                            //final OK Checked
                             qc.CalculateQcAmmount(servicePointId, fromTime, toTime, sqlConnection, incentive_master_id, tran);

                            Penalty.CalculateTechnicianQcBounce(servicePointId, fromTime, penaltyDay, sqlConnection,incentive_master_id, tran);
                          //  Penalty.CalculateReceiverBounce(servicePointId, fromTime, penaltyDay, sqlConnection,  incentive_master_id, tran);
                            Penalty.CalculateCorporateBounce(servicePointId,fromTime,toTime,sqlConnection,incentive_master_id,tran);
                        }
                        /*END*/
                        tran.Commit();
                        logger.Info("Successfully done");

                    }


                    catch (Exception exception)
                    {
                        logger.Fatal(exception.Message, exception);
                        tran.Rollback();
                        WaltonCrmSendMail sendMail = new WaltonCrmSendMail("akash073@waltonbd.com", "ahraihan@waltonbd.com", "Mobile Incentive Policy Failed", exception.Message+"->"+exception.StackTrace);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }


        }



    }
}

