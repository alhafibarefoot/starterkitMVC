DELETE FROM [dbo].[AspNetRoles]
GO
SET IDENTITY_INSERT dbo.AspNetRoles ON
GO

INSERT dbo.AspNetRoles(RoleId,Id, Name, NameAr, Description, Discriminator,isActive) VALUES (N'399e85d1-0fc5-45d3-8259-9145b0f77f29',1, N'Administrator', N'أدمن', NULL, N'ApplicationRole',CONVERT(bit, 'true'))
INSERT dbo.AspNetRoles(RoleId,Id, Name, NameAr, Description, Discriminator,isActive) VALUES (N'52f9014d-2837-44c9-9fba-275c2e31df35',2, N'Controller', N'مراقب النظام', N'His Duty to control the System , Settings ,Dshboard', N'ApplicationRole',CONVERT(bit, 'true'))
INSERT dbo.AspNetRoles(RoleId,Id, Name, NameAr, Description, Discriminator,isActive) VALUES (N'7507c18c-4b5b-42dc-988b-98ae016b3ffe',3, N'Head of Section', N'رئيس قسم', N'He is in Group Head of section ', N'ApplicationRole',CONVERT(bit, 'true'))
INSERT dbo.AspNetRoles(RoleId,Id, Name, NameAr, Description, Discriminator,isActive) VALUES (N'994fa3fb-9e32-49c2-8c35-a65d089d15cf',4, N'Director @ Directorate', N'مدير إدارة', N'He is in Group of directors ', N'ApplicationRole',CONVERT(bit, 'true'))
INSERT dbo.AspNetRoles(RoleId,Id, Name, NameAr, Description, Discriminator,isActive) VALUES (N'ab88698a-6a84-4692-90db-f5337674f0cc',5, N'Employee', N'موظف', N'He is in Group of employees ', N'ApplicationRole',CONVERT(bit, 'true'))
INSERT dbo.AspNetRoles(RoleId,Id, Name, NameAr, Description, Discriminator,isActive) VALUES (N'ff1ec1e0-d552-4bee-bc5c-6c0bf307bca6',6, N'User', N'مستخدم', N'He is in Group of users involve in the system ', N'ApplicationRole',CONVERT(bit, 'true'))
GO

SET IDENTITY_INSERT dbo.AspNetRoles OFF
GO