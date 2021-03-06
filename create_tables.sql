CREATE TABLE [Tasks] (
	Id int NOT NULL identity,
	Name nvarchar(100) NOT NULL,
	Date date NOT NULL,
	Time time NOT NULL,
	PriorityId int NOT NULL,
	Tag nvarchar(100),
	Comment nvarchar(500) NOT NULL,
	ProjectId int NOT NULL,
	IsDone bit NOT NULL,
  CONSTRAINT [PK_TASKS] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Projects] (
	Id int NOT NULL identity,
	Name nvarchar(100) NOT NULL,
  CONSTRAINT [PK_PROJECTS] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Priority] (
	Id int NOT NULL identity,
	Name nvarchar(100) NOT NULL,
  CONSTRAINT [PK_PRIORITY] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
ALTER TABLE [Tasks] WITH CHECK ADD CONSTRAINT [Tasks_fk0] FOREIGN KEY ([PriorityId]) REFERENCES [Priority]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Tasks] CHECK CONSTRAINT [Tasks_fk0]
GO
ALTER TABLE [Tasks] WITH CHECK ADD CONSTRAINT [Tasks_fk1] FOREIGN KEY ([ProjectId]) REFERENCES [Projects]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Tasks] CHECK CONSTRAINT [Tasks_fk1]
GO


