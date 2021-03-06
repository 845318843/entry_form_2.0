USE [JZT_SignUp]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/28/2017 17:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [nvarchar](20) NOT NULL,
	[Pwd] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Users] ([UserName], [Pwd]) VALUES (N'JZT', N'jointown')
INSERT [dbo].[Users] ([UserName], [Pwd]) VALUES (N'jzt', N'jointown')
INSERT [dbo].[Users] ([UserName], [Pwd]) VALUES (N'JZT', N'jointown')
INSERT [dbo].[Users] ([UserName], [Pwd]) VALUES (N'jzt', N'jointown')
/****** Object:  Table [dbo].[Student]    Script Date: 10/28/2017 17:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](10) NULL,
	[Gender] [nvarchar](10) NULL,
	[Student_ID] [nvarchar](13) NULL,
	[Phone] [nvarchar](13) NULL,
	[QQ] [nvarchar](11) NULL,
	[Banji] [nvarchar](20) NULL,
	[Describe] [nvarchar](100) NULL,
	[IsTrain] [nvarchar](10) NULL,
	[Time] [nvarchar](30) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'人数记录' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Gender'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Student_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QQ号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'QQ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'班级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Banji'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'个人描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Describe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否参加集训' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'IsTrain'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报名时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Time'
GO
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (1, N'52', N'男', N'45687', N'13461345785', N'453654', N'4564', N'4868756876578', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (2, N'15', N'男', N'465', N'13461345785', N'4568', N'4658', N'48687', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (3, N'123', N'男', N'123', N'13461345785', N'123', N'123', N'257273685', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (4, N'zaigdfgs', N'男', N'453', N'13461345755', N'5424', N'45354', N'gfsgsdgherhtsr', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (5, N'45', N'男', N'486', N'13461345785', N'463', N'436', N'4568', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (6, N'5887', N'男', N'48678', N'13868765876', N'486', N'486', N'786786', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (7, N'58758', N'男', N'68876', N'13568768768', N'78687567', N'4563213', N'78687687', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (9, N'242', N'男', N'6887', N'13687678687', N'485', N'43687', N'7868768', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (10, N'张三', N'男', N'1707777777', N'13111111111', N'1234567894', N'计科一班', N'2', N'参加', NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (11, N'1', N'男', N'1', N'13235435877', N'1', N'1', N'75876786', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (12, N'25', N'男', N'863', N'13375678678', N'453', N'483', N'786876', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (13, N'5275', N'男', N'786', N'13875678567', N'785', N'786', N'7896/85', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (14, N'543285', N'男', N'', N'13537638646', N'245247', N'2543257', N'53685', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (15, N'张三', N'男', N'7879456', N'13464568945', N'123456789', N'计科一班', N'咳咳咳咳', NULL, N'117/8/15/ 16:5:33')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (16, N'587', N'男', N'78678', N'13687678678', N'786', N'786', N'785678687', NULL, N'117/8/15/ 16:7:17')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (17, N'5875', N'男', N'78678', N'13687678674', N'786', N'786', N'785678687', NULL, N'117/8/15/ 16:8:7')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (18, N'17528757', N'男', N'87687', N'13546876786', N'8567863', N'876', N'7869/', NULL, N'2017/8/15/ 16:8:23')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (19, N'25', N'男', N'78', N'13558788888', N'75', N'786', N'8888888', NULL, N'2017/8/15/ 16:8:46')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (20, N'14', N'男', N'786', N'13548677777', N'14275', N'76', N'78678687', NULL, N'2017/8/15/ 16:9:25')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (21, N'14', N'男', N'78687', N'13545678677', N'2875', N'786387', N'48676', NULL, N'2017/8/15/ 16:9:58')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (22, N'一二', N'男', N'1789466666', N'13464974564', N'57865867', N'几科乙肝', N'354', NULL, N'2017/8/15/ 16:17:56')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (23, N'的说法', N'女', N'1705888888', N'13555555555', N'2', N'是广告法规防腐漆', N'248578', NULL, N'2017/8/16/ 12:11:44')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (24, N'广汇股份', N'男', N'1704528888', N'13654444444', N'17587', N'45257孤鸿寡鹄', N'278578', NULL, N'2017/8/16/ 12:20:47')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (25, N'张三', N'男', N'1701655555', N'13444444444', N'1154555555', N'规范化454', N'2782587', NULL, N'2017/8/16/ 12:32:26')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (26, N'1234', N'男', N'123456789', N'1234', N'123789999', N'123', N'123', NULL, N'123')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (27, N'张三', N'男', N'1702223333', N'13666666666', N'1234567844', N'15几科', N'1234567890', NULL, N'2017/8/19/ 18:5:6')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (28, N'张三', N'男', N'1701111225', N'17889533255', N'5456', N'计科一班', N'123456', NULL, N'2017/8/20/ 20:47:37')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (29, N'马六', N'男', N'1702225566', N'17855588522', N'1234578', N'计科一班', N'1545646', NULL, N'2017/81/20/ 20:49:0')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (31, N'张三', N'男', N'1702355655', N'13333333333', N'123456456', N'计科一班', N'123456', N'参加', N'2017/9/23/ 10:2:49')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (8, N'876786', N'786876', N'6876', N'87687', N'78678', N'87687', N'786786', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (30, N'张三', N'男', N'1702222222', N'17777777778', N'132465465', N'金钩ie叫我', N'48768', NULL, N'2017/9/20/ 20:50:47')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (1, N'52', N'男', N'45687', N'13461345785', N'453654', N'4564', N'4868756876578', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (2, N'15', N'男', N'465', N'13461345785', N'4568', N'4658', N'48687', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (3, N'123', N'男', N'123', N'13461345785', N'123', N'123', N'257273685', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (4, N'zaigdfgs', N'男', N'453', N'13461345755', N'5424', N'45354', N'gfsgsdgherhtsr', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (5, N'45', N'男', N'486', N'13461345785', N'463', N'436', N'4568', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (6, N'5887', N'男', N'48678', N'13868765876', N'486', N'486', N'786786', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (7, N'58758', N'男', N'68876', N'13568768768', N'78687567', N'4563213', N'78687687', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (9, N'242', N'男', N'6887', N'13687678687', N'485', N'43687', N'7868768', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (10, N'张三', N'男', N'1707777777', N'13111111111', N'1234567894', N'计科一班', N'2', N'参加', NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (11, N'1', N'男', N'1', N'13235435877', N'1', N'1', N'75876786', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (12, N'25', N'男', N'863', N'13375678678', N'453', N'483', N'786876', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (13, N'5275', N'男', N'786', N'13875678567', N'785', N'786', N'7896/85', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (14, N'543285', N'男', N'', N'13537638646', N'245247', N'2543257', N'53685', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (15, N'张三', N'男', N'7879456', N'13464568945', N'123456789', N'计科一班', N'咳咳咳咳', NULL, N'117/8/15/ 16:5:33')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (16, N'587', N'男', N'78678', N'13687678678', N'786', N'786', N'785678687', NULL, N'117/8/15/ 16:7:17')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (17, N'5875', N'男', N'78678', N'13687678674', N'786', N'786', N'785678687', NULL, N'117/8/15/ 16:8:7')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (18, N'17528757', N'男', N'87687', N'13546876786', N'8567863', N'876', N'7869/', NULL, N'2017/8/15/ 16:8:23')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (19, N'25', N'男', N'78', N'13558788888', N'75', N'786', N'8888888', NULL, N'2017/8/15/ 16:8:46')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (20, N'14', N'男', N'786', N'13548677777', N'14275', N'76', N'78678687', NULL, N'2017/8/15/ 16:9:25')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (21, N'14', N'男', N'78687', N'13545678677', N'2875', N'786387', N'48676', NULL, N'2017/8/15/ 16:9:58')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (22, N'一二', N'男', N'1789466666', N'13464974564', N'57865867', N'几科乙肝', N'354', NULL, N'2017/8/15/ 16:17:56')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (23, N'的说法', N'女', N'1705888888', N'13555555555', N'2', N'是广告法规防腐漆', N'248578', NULL, N'2017/8/16/ 12:11:44')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (24, N'广汇股份', N'男', N'1704528888', N'13654444444', N'17587', N'45257孤鸿寡鹄', N'278578', NULL, N'2017/8/16/ 12:20:47')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (25, N'张三', N'男', N'1701655555', N'13444444444', N'1154555555', N'规范化454', N'2782587', NULL, N'2017/8/16/ 12:32:26')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (26, N'1234', N'男', N'123456789', N'1234', N'123789999', N'123', N'123', NULL, N'123')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (27, N'张三', N'男', N'1702223333', N'13666666666', N'1234567844', N'15几科', N'1234567890', NULL, N'2017/8/19/ 18:5:6')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (28, N'张三', N'男', N'1701111225', N'17889533255', N'5456', N'计科一班', N'123456', NULL, N'2017/8/20/ 20:47:37')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (29, N'马六', N'男', N'1702225566', N'17855588522', N'1234578', N'计科一班', N'1545646', NULL, N'2017/81/20/ 20:49:0')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (31, N'张三', N'男', N'1702355655', N'13333333333', N'123456456', N'计科一班', N'123456', N'参加', N'2017/9/23/ 10:2:49')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (8, N'876786', N'786876', N'6876', N'87687', N'78678', N'87687', N'786786', NULL, NULL)
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Student_ID], [Phone], [QQ], [Banji], [Describe], [IsTrain], [Time]) VALUES (30, N'张三', N'男', N'1702222222', N'17777777778', N'132465465', N'金钩ie叫我', N'48768', NULL, N'2017/9/20/ 20:50:47')
SET IDENTITY_INSERT [dbo].[Student] OFF
