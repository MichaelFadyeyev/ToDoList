create proc sp_SelectProjects
as
begin
	SELECT * FROM Projects
end
go

EXEC sp_SelectProjects
go

create proc sp_SelectPriority
as
begin
	SELECT * FROM Priority
end
go

EXEC sp_SelectPriority
go


alter proc sp_SelectTasks
as
begin
	select t.Id, t.[Name], t.[Date], t.[Time], 
	pr.[Id] as PriorityId, pr.[Name] as PriorityName,
	t.Tag, t.Comment,
	pj.[Id] as ProjectId, pj.[Name] as ProjectName,
	t.IsDone
	from Tasks as t
	join [Priority] as pr on t.PriorityId = pr.Id
	join [Projects] as pj on t.ProjectId = pj.Id
    order by t.[Date], t.[Time]
end
go

exec sp_SelectTasks
go

create proc sp_AddTask
    @Name       NVARCHAR (100),
    @Date       DATE,
    @Time		TIME (7),
    @PriorityId INT,
    @Tag        NVARCHAR (100),
    @Comment    NVARCHAR (500),
    @ProjectId  INT,
    @IsDone     BIT
as
begin
	insert into Tasks ([Name], [Date], [Time], [PriorityId], [Tag], [Comment], [ProjectId], [IsDone])
	values (@Name, @Date, @Time, @PriorityId, @Tag, @Comment, @ProjectId, @IsDone)
end
go

create proc sp_UpdateTask
    @Id         INT,
    @Name       NVARCHAR (100),
    @Date       DATE,
    @Time		TIME (7),
    @PriorityId INT,
    @Tag        NVARCHAR (100),
    @Comment    NVARCHAR (500),
    @ProjectId  INT,
    @IsDone     BIT
as
begin
    update Tasks set
    [Name] =        @Name,
    [Date] =        @Date,
    [Time] =        @Time,
    [PriorityId] =  @PriorityId,
    [Tag] =         @Tag,
    [Comment] =     @Comment,
    [ProjectId] =   @ProjectId,
    [IsDone] =      @IsDone
    WHERE 
    Id = @Id
end
go

exec sp_DeleteTask 17
go

create proc sp_DeleteTask
@Id         INT
as
begin
    delete Tasks
    WHERE 
    Id = @Id
end
go