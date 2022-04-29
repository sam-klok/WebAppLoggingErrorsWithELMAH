It's sample .Net Framework 4.7.2 web applicaton with MVC and database access.
Purpose is to show how to work with Errol logging library ELMAH.
Also it's a demo of Entity Framework (database first) and MVC. 
Later I will develop .Core version of it..

To run open page:
https://localhost:44365/Ludi/Index

To create database, used in this demo, use SQL from https://github.com/sam-klok/BasicSqlJoins

thank you,
Sam Klok
2022

Used:
1. Install Entity Framework 6 
https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

Connection strings and models
https://docs.microsoft.com/en-us/ef/ef6/fundamentals/configuring/connection-strings

. Accessing your Model's Data from a Controller
https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/getting-started-with-mvc/getting-started-with-mvc-part5

2. Logging Error Details with ELMAH (C#)
https://docs.microsoft.com/en-us/aspnet/web-forms/overview/older-versions-getting-started/deploying-web-site-projects/logging-error-details-with-elmah-cs

2.1. Install NuGet Package elmah
2.2. Run SQL script \SQL\Generate_ELMAH_table_SQLServer.sql  (download it from https://github.com/elmah/Elmah/tree/v1.2-sp2/src/Elmah/SQLServer.sql )

2.3. Use URL for text exception logging:
https://localhost:44365/elmah.axd/test

2.4. Use URL https://localhost:44365/elmah.axd to see list of logged errors from DB.


While developing, I discovered errors, which I fixed.
1.  Message=The ADO.NET provider with invariant name 'System.Data.SqlServerCe.4.0' is either not registered in the machine or application config file, or could not be loaded. See the inner exception for details.
  Source=EntityFramework
Inner Exception 1:
ArgumentException: Unable to find the requested .Net Framework Data Provider.  It may not be installed.

Fix: 
Installing NuGet package: System.Data.SqlServer
And replaced connection string to use System.Data.SqlClient

2. System.Data.Entity.ModelConfiguration.ModelValidationException
  Message=One or more validation errors were detected during model generation:
WebAppLoggingErrorsWithELMAH.DAL.Ludi: : EntityType 'Ludi' has no key defined. Define the key for this EntityType.
Ludi: EntityType: EntitySet 'Ludi' is based on type 'Ludi' that has no keys defined.

Fix:
added [Key] to the model

