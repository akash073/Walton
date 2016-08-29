CREATE TRIGGER [dbo].[Customer_INSERT]
       ON [dbo].[Customers]
AFTER INSERT
AS
BEGIN
       SET NOCOUNT ON;
 
       DECLARE @CustomerId INT
 
       SELECT @CustomerId = INSERTED.CustomerId       
       FROM INSERTED
 
       INSERT INTO CustomerLogs
       VALUES(@CustomerId, 'Inserted')
END

CREATE TRIGGER [dbo].[Customer_UPDATE]
       ON [dbo].[Customers]
AFTER UPDATE
AS
BEGIN
       SET NOCOUNT ON;
 
       DECLARE @CustomerId INT
       DECLARE @Action VARCHAR(50)
 
       SELECT @CustomerId = INSERTED.CustomerId       
       FROM INSERTED
 
       IF UPDATE(Name)
       BEGIN
              SET @Action = 'Updated Name'
       END
 
       IF UPDATE(Country)
       BEGIN
              SET @Action = 'Updated Country'
       END
 
       INSERT INTO CustomerLogs
       VALUES(@CustomerId, @Action)
END

CREATE TRIGGER [dbo].[Customer_DELETE]
       ON [dbo].[Customers]
AFTER DELETE
AS
BEGIN
       SET NOCOUNT ON;
 
       DECLARE @CustomerId INT
 
       SELECT @CustomerId = DELETED.CustomerId       
       FROM DELETED
 
       INSERT INTO CustomerLogs
       VALUES(@CustomerId, 'Deleted')
END
/*all trigger*/
alter trigger Crud_trigger
on [dbo].[Customers]
after UPDATE, INSERT, DELETE
as
declare @action varchar(20);
Declare @HostName nvarchar(max);
Declare @client_net_address sql_variant;
Declare @LoggedInUser nvarchar(max);
declare @UpdatedDate datetime2(7);
declare @DealerdistributionId uniqueidentifier;
declare @DealerCode varchar(50);
declare @BarCode varchar(500);
declare @BarCode2 varchar(500);
declare @Model varchar(200);
declare @DONumber varchar(50);
declare @DistributionDate date;
SELECT @HostName= HOST_NAME() ,@client_net_address=CONNECTIONPROPERTY('client_net_address')  ,@LoggedInUser= SUSER_NAME() ,@UpdatedDate=GETDATE();
if exists(SELECT * from inserted) and exists (SELECT * from deleted)
begin
    SET @action = 'UPDATE';
  --  SELECT @CustomerId = CustomerId from inserted i;
  --SELECT 
  --    [DealerdistributionId]
  --    ,[DealerCode]
  --    ,[BarCode]
  --    ,[BarCode2]
  --    ,[Model]
  --    ,[DONumber]
  --    ,[DistributionDate]
  --FROM [TrigerExamples].[dbo].[DealerDistributionTriggerLogs]
    INSERT into DealerDistributionTriggerLogs([action]
      ,[HostName]
      ,[client_net_address]
      ,[LoggedInUser]
      ,[UpdatedDate]
	  ,[DealerdistributionId]
      ,[DealerCode]
      ,[BarCode]
      ,[BarCode2]
      ,[Model]
      ,[DONumber]
      ,[DistributionDate]) values (@action
      ,@HostName
      ,@client_net_address
      ,@LoggedInUser
      ,@UpdatedDate
	  ,@DealerdistributionId
      ,@DealerCode
      ,@BarCode
      ,@BarCode2
      ,@Model
      ,@DONumber
      ,@DistributionDate);
end

If exists (Select * from inserted) and not exists(Select * from deleted)
begin
     SET @action = 'INSERT';
    --SELECT @CustomerId = CustomerId from inserted i;
    --INSERT into CustomerLogs values (@CustomerId,@action);
end

If exists(select * from deleted) and not exists(Select * from inserted)
begin 
    SET @action = 'DELETE';
   
    --SELECT @CustomerId = CustomerId from deleted i;
    --INSERT into CustomerLogs values (@CustomerId,@action);
end
Go

select convert(nvarchar(36), GUID) as requestID

	nvarchar(MAX)	Checked
	nvarchar(MAX)	Checked
	nvarchar(MAX)	Checked

DealerdistributionId	nvarchar(MAX)	Checked
DealerCode	varchar(50)	Checked
BarCode	varchar(500)	Checked
BarCode2	varchar(500)	Checked
Model	varchar(200)	Checked
DONumber	varchar(50)	Checked
DistributionDate	date	Checked

