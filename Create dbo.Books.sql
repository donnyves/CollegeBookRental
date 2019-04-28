USE [aspnet-CollegeBook]
GO

/****** Object: Table [dbo].[Books] Script Date: 4/22/2019 11:34:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Books] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [ISBN]              NVARCHAR (MAX) NOT NULL,
    [Title]             NVARCHAR (MAX) NOT NULL,
    [Author]            NVARCHAR (MAX) NOT NULL,
    [Description]       NVARCHAR (MAX) NOT NULL,
    [ImageUrl]          NVARCHAR (MAX) NOT NULL,
    [Availbility]       INT            NOT NULL,
    [Price]             FLOAT (53)     NOT NULL,
    [DateAdded]         DATETIME       NOT NULL,
    [GenreId]           INT            NOT NULL,
    [Publisher]         NVARCHAR (MAX) NOT NULL,
    [PublicationDate]   DATETIME       NOT NULL,
    [Pages]             INT            NOT NULL,
    [ProductDimensions] NVARCHAR (MAX) NOT NULL
);


