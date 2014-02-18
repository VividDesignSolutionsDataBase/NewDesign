
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/15/2014 01:37:45
-- Generated from EDMX file: C:\Users\Darian\Documents\_SCHOOL\Niloufar-UNF\Senior Project 1\JSO Project\DisciplinaryReport\DisciplinaryReport\DRdb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DRdb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DRHearings'
CREATE TABLE [dbo].[DRHearings] (
    [DR_HEAR_CHIEF_ID] nvarchar(max)  NOT NULL,
    [DRInvestigationDR_INVEST_EMP_ID] nvarchar(max)  NOT NULL,
    [DRInvestigationDisciplinaryReportDR_REPORT_NUM] int  NOT NULL,
    [DRInvestigationDisciplinaryReportDR_FIRST_APPROVAL_EMP_ID] nvarchar(max)  NOT NULL,
    [DRInvestigationDisciplinaryReportEmployeeEMP_ID] nvarchar(max)  NOT NULL,
    [DR_HEAR_INM_PLEA] nvarchar(max)  NOT NULL,
    [DR_HEAR_WIT_REQ] nvarchar(max)  NOT NULL,
    [DR_HEAR_NO_REAPORTS] nvarchar(max)  NOT NULL,
    [DR_HEAR_DATE] datetime  NOT NULL,
    [DR_HEAR_DEC] nvarchar(max)  NOT NULL,
    [DR_HEAR_APPEAL] nvarchar(max)  NOT NULL,
    [DR_HEAR_DAYS_DSC_CONF] nvarchar(max)  NOT NULL,
    [DR_HEAR_WKS_LOSS_COMMIS] nvarchar(max)  NOT NULL,
    [DR_HEAR_DAYS_LOSS_GAINTIME] nvarchar(max)  NOT NULL,
    [DR_HEAR_REV_TENT_DEL_DATE] nvarchar(max)  NOT NULL,
    [DR_HEAR_COMMENT] nvarchar(max)  NOT NULL,
    [DR_HEAR_INM_INSTRULES_ACK] nvarchar(max)  NOT NULL,
    [DR_HEAR_COM_CHAIR_ID] nvarchar(max)  NOT NULL,
    [DR_HEAR_INM_WIT_ID] nvarchar(max)  NOT NULL,
    [DR_HEAR_CHIEF_AGREE_FLAG] nvarchar(max)  NOT NULL,
    [DR_HEAR_CHIEF_REDUCE_FLAG] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DRInvestigations'
CREATE TABLE [dbo].[DRInvestigations] (
    [DR_INVEST_EMP_ID] nvarchar(max)  NOT NULL,
    [DisciplinaryReportDR_REPORT_NUM] int  NOT NULL,
    [DisciplinaryReportDR_FIRST_APPROVAL_EMP_ID] nvarchar(max)  NOT NULL,
    [DisciplinaryReportEmployeeEMP_ID] nvarchar(max)  NOT NULL,
    [DR_INVEST_DATE] datetime  NOT NULL,
    [DR_DATE_INVEST_COMP] nvarchar(max)  NOT NULL,
    [DR_TIME_INVEST_COMP] nvarchar(max)  NOT NULL,
    [DR_INVEST_STATEMENT] nvarchar(max)  NOT NULL,
    [DR_INVEST_COMP_FLAG] nvarchar(max)  NOT NULL,
    [DR_INVEST_VOID] nvarchar(max)  NOT NULL,
    [DR_INVEST_APPROVE] nvarchar(max)  NOT NULL,
    [DR_INVEST_REJECT] nvarchar(max)  NOT NULL,
    [DR_INVEST_REJ_REASON] nvarchar(max)  NOT NULL,
    [DR_INVEST_SUP_VOID] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DisciplinaryReports'
CREATE TABLE [dbo].[DisciplinaryReports] (
    [DR_REPORT_NUM] int IDENTITY(1,1) NOT NULL,
    [DR_FIRST_APPROVAL_EMP_ID] nvarchar(max)  NOT NULL,
    [EmployeeEMP_ID] nvarchar(max)  NOT NULL,
    [DR_INM_VIOLATION_CODE] nvarchar(max)  NOT NULL,
    [DR_INM_LAST_NAME] nvarchar(max)  NOT NULL,
    [DR_INM_FIRST_NAME] nvarchar(max)  NOT NULL,
    [DR_INM_RACE] nvarchar(max)  NOT NULL,
    [DR_INM_SEX] nvarchar(max)  NOT NULL,
    [DR_INM_AGE] nvarchar(max)  NOT NULL,
    [DR_FACILITY] nvarchar(max)  NOT NULL,
    [DR_FAC_LOCATION] nvarchar(max)  NOT NULL,
    [DR_INM_CONT_LOG] nvarchar(max)  NOT NULL,
    [DR_INCIDENT_DATE] datetime  NOT NULL,
    [DR_INCIDENT_TIME] time  NOT NULL,
    [DR_INCIDENT_LOCATION] nvarchar(max)  NOT NULL,
    [DR_STATE_FACTS] nvarchar(max)  NOT NULL,
    [DR_DATE_INTISUB_COMP] nvarchar(max)  NOT NULL,
    [DR_INITSUB_COMP] nvarchar(max)  NOT NULL,
    [DR_FIRST_APPROVAL_FLAG] nvarchar(max)  NOT NULL,
    [DR_FIRST_REJECT_REASON] nvarchar(max)  NOT NULL,
    [DR_FIRST_REJECT_FLAG] nvarchar(max)  NOT NULL,
    [LocationLOC_FAC_CODE] nvarchar(max)  NOT NULL,
    [ViolationVIO_CODE] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [LOC_FAC_CODE] nvarchar(max)  NOT NULL,
    [LOC_FAC_DESC] nvarchar(max)  NOT NULL,
    [LOC_CODE] nvarchar(max)  NOT NULL,
    [LOC_DESC] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Violations'
CREATE TABLE [dbo].[Violations] (
    [VIO_CODE] nvarchar(max)  NOT NULL,
    [VIO_SHORT_DESC] nvarchar(max)  NOT NULL,
    [VIO_LONG_DESC] nvarchar(max)  NOT NULL,
    [VIO_R_FLAG] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [EMP_ID] nvarchar(max)  NOT NULL,
    [EMP_PASSW] nvarchar(max)  NOT NULL,
    [EMP_LAST_NAME] nvarchar(max)  NOT NULL,
    [EMP_FIRST_NAME] nvarchar(max)  NOT NULL,
    [EMP_ROLE] nvarchar(max)  NOT NULL,
    [EMP_LOCATION] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DR_HEAR_CHIEF_ID], [DRInvestigationDR_INVEST_EMP_ID], [DRInvestigationDisciplinaryReportDR_REPORT_NUM], [DRInvestigationDisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DRInvestigationDisciplinaryReportEmployeeEMP_ID] in table 'DRHearings'
ALTER TABLE [dbo].[DRHearings]
ADD CONSTRAINT [PK_DRHearings]
    PRIMARY KEY CLUSTERED ([DR_HEAR_CHIEF_ID], [DRInvestigationDR_INVEST_EMP_ID], [DRInvestigationDisciplinaryReportDR_REPORT_NUM], [DRInvestigationDisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DRInvestigationDisciplinaryReportEmployeeEMP_ID] ASC);
GO

-- Creating primary key on [DR_INVEST_EMP_ID], [DisciplinaryReportDR_REPORT_NUM], [DisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DisciplinaryReportEmployeeEMP_ID] in table 'DRInvestigations'
ALTER TABLE [dbo].[DRInvestigations]
ADD CONSTRAINT [PK_DRInvestigations]
    PRIMARY KEY CLUSTERED ([DR_INVEST_EMP_ID], [DisciplinaryReportDR_REPORT_NUM], [DisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DisciplinaryReportEmployeeEMP_ID] ASC);
GO

-- Creating primary key on [DR_REPORT_NUM], [DR_FIRST_APPROVAL_EMP_ID], [EmployeeEMP_ID] in table 'DisciplinaryReports'
ALTER TABLE [dbo].[DisciplinaryReports]
ADD CONSTRAINT [PK_DisciplinaryReports]
    PRIMARY KEY CLUSTERED ([DR_REPORT_NUM], [DR_FIRST_APPROVAL_EMP_ID], [EmployeeEMP_ID] ASC);
GO

-- Creating primary key on [LOC_FAC_CODE] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([LOC_FAC_CODE] ASC);
GO

-- Creating primary key on [VIO_CODE] in table 'Violations'
ALTER TABLE [dbo].[Violations]
ADD CONSTRAINT [PK_Violations]
    PRIMARY KEY CLUSTERED ([VIO_CODE] ASC);
GO

-- Creating primary key on [EMP_ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([EMP_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmployeeEMP_ID] in table 'DisciplinaryReports'
ALTER TABLE [dbo].[DisciplinaryReports]
ADD CONSTRAINT [FK_EmployeeDisciplinaryReport]
    FOREIGN KEY ([EmployeeEMP_ID])
    REFERENCES [dbo].[Employees]
        ([EMP_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeDisciplinaryReport'
CREATE INDEX [IX_FK_EmployeeDisciplinaryReport]
ON [dbo].[DisciplinaryReports]
    ([EmployeeEMP_ID]);
GO

-- Creating foreign key on [LocationLOC_FAC_CODE] in table 'DisciplinaryReports'
ALTER TABLE [dbo].[DisciplinaryReports]
ADD CONSTRAINT [FK_LocationDisciplinaryReport]
    FOREIGN KEY ([LocationLOC_FAC_CODE])
    REFERENCES [dbo].[Locations]
        ([LOC_FAC_CODE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationDisciplinaryReport'
CREATE INDEX [IX_FK_LocationDisciplinaryReport]
ON [dbo].[DisciplinaryReports]
    ([LocationLOC_FAC_CODE]);
GO

-- Creating foreign key on [ViolationVIO_CODE] in table 'DisciplinaryReports'
ALTER TABLE [dbo].[DisciplinaryReports]
ADD CONSTRAINT [FK_ViolationDisciplinaryReport]
    FOREIGN KEY ([ViolationVIO_CODE])
    REFERENCES [dbo].[Violations]
        ([VIO_CODE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ViolationDisciplinaryReport'
CREATE INDEX [IX_FK_ViolationDisciplinaryReport]
ON [dbo].[DisciplinaryReports]
    ([ViolationVIO_CODE]);
GO

-- Creating foreign key on [DisciplinaryReportDR_REPORT_NUM], [DisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DisciplinaryReportEmployeeEMP_ID] in table 'DRInvestigations'
ALTER TABLE [dbo].[DRInvestigations]
ADD CONSTRAINT [FK_DisciplinaryReportDRInvestigation]
    FOREIGN KEY ([DisciplinaryReportDR_REPORT_NUM], [DisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DisciplinaryReportEmployeeEMP_ID])
    REFERENCES [dbo].[DisciplinaryReports]
        ([DR_REPORT_NUM], [DR_FIRST_APPROVAL_EMP_ID], [EmployeeEMP_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DisciplinaryReportDRInvestigation'
CREATE INDEX [IX_FK_DisciplinaryReportDRInvestigation]
ON [dbo].[DRInvestigations]
    ([DisciplinaryReportDR_REPORT_NUM], [DisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DisciplinaryReportEmployeeEMP_ID]);
GO

-- Creating foreign key on [DRInvestigationDR_INVEST_EMP_ID], [DRInvestigationDisciplinaryReportDR_REPORT_NUM], [DRInvestigationDisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DRInvestigationDisciplinaryReportEmployeeEMP_ID] in table 'DRHearings'
ALTER TABLE [dbo].[DRHearings]
ADD CONSTRAINT [FK_DRInvestigationDRHearing]
    FOREIGN KEY ([DRInvestigationDR_INVEST_EMP_ID], [DRInvestigationDisciplinaryReportDR_REPORT_NUM], [DRInvestigationDisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DRInvestigationDisciplinaryReportEmployeeEMP_ID])
    REFERENCES [dbo].[DRInvestigations]
        ([DR_INVEST_EMP_ID], [DisciplinaryReportDR_REPORT_NUM], [DisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DisciplinaryReportEmployeeEMP_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DRInvestigationDRHearing'
CREATE INDEX [IX_FK_DRInvestigationDRHearing]
ON [dbo].[DRHearings]
    ([DRInvestigationDR_INVEST_EMP_ID], [DRInvestigationDisciplinaryReportDR_REPORT_NUM], [DRInvestigationDisciplinaryReportDR_FIRST_APPROVAL_EMP_ID], [DRInvestigationDisciplinaryReportEmployeeEMP_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------