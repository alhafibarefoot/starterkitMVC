/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

:r .\1_Intilized.sql


:r .\2_Seed_AspNetUsers.sql
:r .\3_Seed_AspNetRoles.sql
:r .\4_Seed_AspNetUserRoles.sql
:r .\5_Seed_SMT_Action.sql
:r .\6_Seed_SMT_Module.sql
:r .\7_Seed_SMT_System.sql
:r .\8_Seed_LT_DivisionType.sql
:r .\9_Seed_LT_Country.sql
:r .\10_Seed_LT_Governorate.sql
:r .\11_LT_Region.sql
:r .\12_Seed_LT_Area.sql
:r .\13_Seed_LT_Road.sql
:r .\14_Seed_SEC_RolePermission.sql
:r .\15_Seed_STR_Company.sql
:r .\16_Seeding_LT_LookupTableReferance.sql






:r .\99_Finilized.sql

