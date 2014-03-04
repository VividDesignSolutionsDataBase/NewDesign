

SET QUOTED_IDENTIFIER OFF;
GO
USE [JSO];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EmployeeDR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DRs] DROP CONSTRAINT [FK_EmployeeDR];
GO
IF OBJECT_ID(N'[dbo].[FK_ViolationDR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DRs] DROP CONSTRAINT [FK_ViolationDR];
GO
IF OBJECT_ID(N'[dbo].[FK_DRDRInvestigation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DRInvestigations] DROP CONSTRAINT [FK_DRDRInvestigation];
GO
IF OBJECT_ID(N'[dbo].[FK_DRInvestigationDRHearing]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DRHearings] DROP CONSTRAINT [FK_DRInvestigationDRHearing];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DRHearings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DRHearings];
GO
IF OBJECT_ID(N'[dbo].[DRInvestigations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DRInvestigations];
GO
IF OBJECT_ID(N'[dbo].[DRs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DRs];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[Violations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Violations];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[HOUSING_LOCATION]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HOUSING_LOCATION];
GO
IF OBJECT_ID(N'[dbo].[INCIDENT_LOCATION]', 'U') IS NOT NULL
    DROP TABLE [dbo].[INCIDENT_LOCATION];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DRHearings'
CREATE TABLE [dbo].[DRHearings] (
    [DRInvestigationDRDR_REPORT_NUM] int  NOT NULL,
    [DR_HEAR_CHIEF_ID] int  NOT NULL,
    [DR_HEAR_INM_PLEA] nvarchar(max)  NOT NULL,
    [DR_HEAR_WIT_REQ] nvarchar(max)  NOT NULL,
    [DR_HEAR_NUM_DISC_REPORTS] nvarchar(max)  NOT NULL,
    [DR_HEAR_DATE] datetime  NOT NULL,
    [DR_HEAR_DECISION] nvarchar(max)  NOT NULL,
    [DR_HEAR_APPEAL] nvarchar(max)  NOT NULL,
    [DR_HEAR_DAYS_DISC_CONFINEMENT] nvarchar(max)  NOT NULL,
    [DR_HEAR_WKS_LOSS_COMMIS] nvarchar(max)  NOT NULL,
    [DR_HEAR_DAYS_LOSS_GAINTIME] nvarchar(max)  NOT NULL,
    [DR_HEAR_REVISED_TENTATIVE_REL_DATE] nvarchar(max)  NOT NULL,
    [DR_HEAR_COMMENT] nvarchar(max)  NOT NULL,
    [DR_HEAR_INM_INSTRULES_ACK] nvarchar(max)  NOT NULL,
    [DR_HEAR_COM_CHAIR_ID] int  NOT NULL,
    [DR_HEAR_INM_WITNESS_JAIL_NUM] nvarchar(max)  NOT NULL,
    [DR_HEAR_CHIEF_AGREE_FLAG] nvarchar(max)  NOT NULL,
    [DR_HEAR_CHIEF_REDUCE_FLAG] nvarchar(max)  NOT NULL,
    [DR_HEAR_APPROVE_FLAG] nvarchar(max)  NOT NULL,
    [DR_HEAR_VOID_FLAG] nvarchar(max)  NOT NULL,
    [DR_HEAR_REDUCT_AMEND] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DRInvestigations'
CREATE TABLE [dbo].[DRInvestigations] (
    [DRDR_REPORT_NUM] int  NOT NULL,
    [DR_INVEST_EMP_ID] int  NOT NULL,
    [DR_DATE_OF_INVEST] datetime  NOT NULL,
    [DR_TIME_OF_INVEST] nvarchar(max)  NOT NULL,
    [DR_DATE_INVEST_COMP] datetime  NOT NULL,
    [DR_TIME_INVEST_COMP] time  NOT NULL,
    [DR_INVEST_STATEMENT] nvarchar(max)  NOT NULL,
    [DR_INVEST_COMP_FLAG] nvarchar(max)  NOT NULL,
    [DR_INVEST_VOID_FLAG] nvarchar(max)  NOT NULL,
    [DR_INVEST_APPROVE_FLAG] nvarchar(max)  NOT NULL,
    [DR_INVEST_REJECT_FLAG] nvarchar(max)  NOT NULL,
    [DR_INVEST_REJ_REASON] nvarchar(max)  NOT NULL,
    [DR_INVEST_SUP_VOID_FLAG] nvarchar(max)  NOT NULL,
    [DR_INVEST_SUP_APPROVE_EMP_ID] int  NOT NULL
);
GO

-- Creating table 'DRs'
CREATE TABLE [dbo].[DRs] (
    [DR_REPORT_NUM] int IDENTITY(1,1) NOT NULL,
    [DR_FIRST_APPROVAL_EMP_ID] int IDENTITY(1,1) NOT NULL,
    [DR_INM_VIOLATION_CODE] nvarchar(max)  NOT NULL,
    [DR_INM_JAIL_NUM] nvarchar(max)  NOT NULL,
    [DR_INM_LAST_NAME] nvarchar(max)  NOT NULL,
    [DR_INM_FIRST_NAME] nvarchar(max)  NOT NULL,
    [DR_INM_RACE] nvarchar(max)  NOT NULL,
    [DR_INM_SEX] nvarchar(max)  NOT NULL,
    [DR_INM_AGE] nvarchar(max)  NOT NULL,
    [DR_OFFICER_FACILITY] nvarchar(max)  NOT NULL,
    [DR_HOUSE_LOC] nvarchar(max)  NOT NULL,
    [DR_CMIS_CONT_LOG] nvarchar(max)  NOT NULL,
    [DR_INCIDENT_DATE] datetime  NOT NULL,
    [DR_INCIDENT_TIME] time  NOT NULL,
    [DR_INCIDENT_LOCATION] nvarchar(max)  NOT NULL,
    [DR_STATE_FACTS] nvarchar(max)  NOT NULL,
    [DR_DATE_INIT_SUBMISSION_COMP] datetime  NOT NULL,
    [DR_INITSUB_COMP_FLAG] nvarchar(max)  NOT NULL,
    [DR_FIRST_APPROVAL_FLAG] nvarchar(max)  NOT NULL,
    [DR_FIRST_REJECT_REASON] nvarchar(max)  NOT NULL,
    [DR_FIRST_REJECT_FLAG] nvarchar(max)  NOT NULL,
    [DR_TIME_INIT_SUBMISSION_COMP] time  NOT NULL,
    [EmployeeEMP_ID] int  NOT NULL,
    [ViolationVIO_CODE] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
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
    [EMP_ID] int  NOT NULL,
    [EMP_PASSW] nvarchar(max)  NOT NULL,
    [EMP_LAST_NAME] nvarchar(max)  NOT NULL,
    [EMP_FIRST_NAME] nvarchar(max)  NOT NULL,
    [EMP_ROLE] nvarchar(max)  NOT NULL,
    [EMP_LOCATION] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HOUSING_LOCATION'
CREATE TABLE [dbo].[HOUSING_LOCATION] (
    [HOUSE_LOC_CODE] nvarchar(max)  NOT NULL,
    [HOUSE_LOC_DESC] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'INCIDENT_LOCATION'
CREATE TABLE [dbo].[INCIDENT_LOCATION] (
    [INC_LOC_CODE] nvarchar(max)  NOT NULL,
    [INC_LOC_DESC] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DRInvestigationDRDR_REPORT_NUM] in table 'DRHearings'
ALTER TABLE [dbo].[DRHearings]
ADD CONSTRAINT [PK_DRHearings]
    PRIMARY KEY CLUSTERED ([DRInvestigationDRDR_REPORT_NUM] ASC);
GO

-- Creating primary key on [DRDR_REPORT_NUM] in table 'DRInvestigations'
ALTER TABLE [dbo].[DRInvestigations]
ADD CONSTRAINT [PK_DRInvestigations]
    PRIMARY KEY CLUSTERED ([DRDR_REPORT_NUM] ASC);
GO

-- Creating primary key on [DR_REPORT_NUM] in table 'DRs'
ALTER TABLE [dbo].[DRs]
ADD CONSTRAINT [PK_DRs]
    PRIMARY KEY CLUSTERED ([DR_REPORT_NUM] ASC);
GO

-- Creating primary key on [LOC_CODE] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([LOC_CODE] ASC);
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

-- Creating primary key on [HOUSE_LOC_CODE] in table 'HOUSING_LOCATION'
ALTER TABLE [dbo].[HOUSING_LOCATION]
ADD CONSTRAINT [PK_HOUSING_LOCATION]
    PRIMARY KEY CLUSTERED ([HOUSE_LOC_CODE] ASC);
GO

-- Creating primary key on [INC_LOC_CODE] in table 'INCIDENT_LOCATION'
ALTER TABLE [dbo].[INCIDENT_LOCATION]
ADD CONSTRAINT [PK_INCIDENT_LOCATION]
    PRIMARY KEY CLUSTERED ([INC_LOC_CODE] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmployeeEMP_ID] in table 'DRs'
ALTER TABLE [dbo].[DRs]
ADD CONSTRAINT [FK_EmployeeDR]
    FOREIGN KEY ([EmployeeEMP_ID])
    REFERENCES [dbo].[Employees]
        ([EMP_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeDR'
CREATE INDEX [IX_FK_EmployeeDR]
ON [dbo].[DRs]
    ([EmployeeEMP_ID]);
GO

-- Creating foreign key on [ViolationVIO_CODE] in table 'DRs'
ALTER TABLE [dbo].[DRs]
ADD CONSTRAINT [FK_ViolationDR]
    FOREIGN KEY ([ViolationVIO_CODE])
    REFERENCES [dbo].[Violations]
        ([VIO_CODE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ViolationDR'
CREATE INDEX [IX_FK_ViolationDR]
ON [dbo].[DRs]
    ([ViolationVIO_CODE]);
GO

-- Creating foreign key on [DRDR_REPORT_NUM] in table 'DRInvestigations'
ALTER TABLE [dbo].[DRInvestigations]
ADD CONSTRAINT [FK_DRDRInvestigation]
    FOREIGN KEY ([DRDR_REPORT_NUM])
    REFERENCES [dbo].[DRs]
        ([DR_REPORT_NUM])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DRInvestigationDRDR_REPORT_NUM] in table 'DRHearings'
ALTER TABLE [dbo].[DRHearings]
ADD CONSTRAINT [FK_DRInvestigationDRHearing]
    FOREIGN KEY ([DRInvestigationDRDR_REPORT_NUM])
    REFERENCES [dbo].[DRInvestigations]
        ([DRDR_REPORT_NUM])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------