/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) 
	[PersonID]
      ,[Name]
      ,[PhoneID]
  FROM [LifelongLearning].[dbo].[Ludi]

-- Incorrectly generated Linq query
SELECT 
	[Extent1].[PersonID] AS [PersonID], 
	[Extent1].[Name] AS [Name], 
	[Extent1].[PhoneID] AS [PhoneID]
	FROM [dbo].[People] AS [Extent1]

-- another incorrect generation (Ludis, not Ludi)
SELECT 
    [Extent1].[PersonID] AS [PersonID], 
    [Extent1].[Name] AS [Name], 
    [Extent1].[PhoneID] AS [PhoneID]
    FROM [dbo].[Ludis] AS [Extent1]

-- finally right
SELECT 
    [Extent1].[PersonID] AS [PersonID], 
    [Extent1].[Name] AS [Name], 
    [Extent1].[PhoneID] AS [PhoneID]
    FROM [dbo].[Ludi] AS [Extent1]