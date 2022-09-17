Delete from [dbo].[SMT_Action]
GO

SET IDENTITY_INSERT dbo.SMT_Action ON
GO
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0001', 1, N'استعلام', N'View')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0002', 2, N'إضافة', N'Add')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0003', 3, N'تصحيح', N'Edit')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0004', 4, N'حذف', N'Delete')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0005', 5, N'موافقة', N'Approve')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0006', 6, N'رفض', N'Reject')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0007', 7, N'تصدير', N'Export')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0008', 8, N'طباعة', N'Print')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0009', 9, N'ارسال بريد الكتروني', N'SendMail')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0010', 10, N'تصدير إكسيل', N'ExportExcel')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0011', 11, N'تصدير PDF', N'ExportPDF')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0012', 12, N'تصدير المستند', N'ExportDoc')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0013', 13, N'انتداب', N'Delegate')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0014', 14, N'تحميل', N'Upload')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0015', 15, N'بحث', N'Search')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0016', 16, N'الغاء التفعيل', N'Deactivate')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0017', 17, N'إعادة ضبط كلمة المرور', N'Reset Password')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0018', 18, N'تغيير الايميل', N'Change Email')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0019', 19, N'تغيير صورة المستخدم', N'Change User Photo')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0020', 20, N'حفظ المسودة', N'Save Draft')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0021', 21, N'ارسال', N'Submit')
INSERT dbo.SMT_Action(Action_Code, Id, ActionNameAr, ActionNameEn) VALUES (N'ACT-0022', 22, N'إعادة تعيين', N'Reassign')
GO
SET IDENTITY_INSERT dbo.SMT_Action OFF
GO