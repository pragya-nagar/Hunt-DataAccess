using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class WorkflowMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create or replace function main.get_status(task_id uuid) returns integer as $$
declare
	completion_type integer;
	due_date date;
	assigned integer;
	completed integer;									  
	dependency_type integer;							  
	dependencies uuid[];
	dep_id uuid;
begin
	if task_id is null then
		return 0;
	end if;
	
	select
		tmp.""CompletionType"",
		tmp.""DueDate"",
		tmp.""DependencyTypeId"",
		tmp.""Assigned"",
		tmp.""Completed"",
		ARRAY_AGG(tmp.""DependencyId"")::uuid[] ""Dependencies""
	into 
		completion_type,
		due_date,
		dependency_type,
		assigned,
		completed,
		dependencies
	from (	select
				t.""Id"",
				case
					when td.""LogicTypeId"" in (14, 15) then 1
					else coalesce(t.""CompletionType"", 2)
				end ""CompletionType"",
				case
					when td.""TriggerSourceTypeId"" = 1 then e.""SaleDate""::date + td.""TriggerDayOffset""::integer
					when td.""TriggerSourceTypeId"" = 2 then e.""FundingDate""::date + td.""TriggerDayOffset""::integer
				end ""DueDate"",
				wtd.""DependencyTypeId"",
				a.""Assigned"",
				a.""Completed"",
				wtdep.""DependencyId""
			from main.""Task"" t
				inner join main.""TaskDefinition"" td on td.""Id"" = t.""TaskDefinitionId""
				inner join main.""Workflow"" w on w.""Id"" = t.""WorkflowId""	
				inner join main.""Event"" e on e.""Id"" = w.""EventId""
				inner join main.""WorkflowDefinition"" wd on wd.""Id"" = w.""WorkflowDefinitionId""
				inner join main.""UnderwritingWorkflowTaskDefinition"" wtd on wtd.""TaskDefinitionId"" = td.""Id"" and wtd.""WorkflowDefinitionId"" = wd.""Id""
				left join main.""UnderwritingWorkflowTaskDependency"" wtdep on wtdep.""DependentId"" = wtd.""Id""
				left join (	select
								tu.""TaskId"",
								count(tu.""TaskId"") ""Assigned"",
								sum(case when tu.""CompletedDate"" is null then 0 else 1 end) ""Completed""
							from main.""TaskUser"" tu
							group by tu.""TaskId"") a on t.""Id"" = a.""TaskId"") tmp
	where tmp.""Id"" = task_id
	group by
		tmp.""Id"",
		tmp.""CompletionType"",
		tmp.""DueDate"",
		tmp.""DependencyTypeId"",
		tmp.""Assigned"",
		tmp.""Completed"";
	
	if assigned is null or assigned = 0 then
		return 0;
	end if;
										   
	if array_length(dependencies, 1) > 0 then
  		foreach dep_id in array dependencies loop
			if dep_id is not null and main.get_status(dep_id) = 0 then
				return 0;
			end if;
		end loop;
	end if;
	
	if completion_type = 1 and assigned > 0 and assigned = completed then
		return 2;
	end if;
	
	if completion_type = 2 and completed > 0 then
		return 2;
	end if;
	
	if assigned > 0 and due_date <= current_date then
		return 3;
	end if;
									  
	return 1;	
end; $$
language plpgsql;

insert into main.""Task""(""Id"", ""CreatedOn"", ""CreatedById"", ""ModifiedOn"", ""ModifiedById"", ""DeletedOn"", ""WorkflowId"", ""TaskDefinitionId"", ""WorkflowType"", ""Notes"", ""InstanceNumber"", ""CompletionType"", ""DueDate"", ""Status"")
select
	tmp.""Id"",
	tmp.""CreatedOn"",
	tmp.""CreatedById"",
	tmp.""ModifiedOn"",
	tmp.""ModifiedById"",
	tmp.""DeletedOn"",
	tmp.""WorkflowId"",
	tmp.""TaskDefinitionId"",
	tmp.""WorkflowType"",
	tmp.""Notes"",
	tmp.""InstanceNumber"",
	tmp.""CompletionType"",
	tmp.""DueDate"",
	main.get_status(tmp.""Id"") ""Status""
from (	select
			coalesce(t.""Id"", md5(random()::text || clock_timestamp()::text)::uuid) ""Id"",
			coalesce(t.""CreatedOn"", current_date) ""CreatedOn"",
			coalesce(t.""CreatedById"", '00000000-0000-0000-0000-000000000001'::uuid) ""CreatedById"",
			coalesce(t.""ModifiedOn"", current_date) ""ModifiedOn"",
			coalesce(t.""ModifiedById"", '00000000-0000-0000-0000-000000000001'::uuid) ""ModifiedById"",
			t.""DeletedOn"",
			w.""Id"" ""WorkflowId"",	  
			td.""Id"" ""TaskDefinitionId"",
			w.""WorkflowType"",
			t.""Notes"",
			td.""LogicTypeId"",
			uwtd.""DependencyTypeId"",
			case
				when td.""LogicTypeId"" = 14 and t.""Id"" is null then -1
				else coalesce(t.""InstanceNumber"", 1)
			end ""InstanceNumber"",
			case
				when td.""LogicTypeId"" in (14, 15) then 1
				else coalesce(t.""CompletionType"", 2)
			end ""CompletionType"",
			case
				when td.""TriggerSourceTypeId"" = 1 then e.""SaleDate""::date + td.""TriggerDayOffset""::integer
				when td.""TriggerSourceTypeId"" = 2 then e.""FundingDate""::date + td.""TriggerDayOffset""::integer
			end ""DueDate"",
			a.""Assigned"",
			a.""Completed""
		from main.""Workflow"" w
			inner join main.""Event"" e on e.""Id"" = w.""EventId""
			inner join main.""UnderwritingWorkflowTaskDefinition"" uwtd on uwtd.""WorkflowDefinitionId"" = w.""WorkflowDefinitionId""
			inner join main.""TaskDefinition"" td on td.""Id"" = uwtd.""TaskDefinitionId""
			left join main.""Task"" t on td.""Id"" = t.""TaskDefinitionId"" and w.""Id"" = t.""WorkflowId""
			left join (	select
							tu.""TaskId"",
							count(tu.""TaskId"") ""Assigned"",
							sum(case when tu.""CompletedDate"" is null then 0 else 1 end) ""Completed""
						from main.""TaskUser"" tu
						group by tu.""TaskId"") a on t.""Id"" = a.""TaskId""
		where w.""WorkflowType"" = 1) tmp
on conflict (""Id"") do
		update
		set ""Status"" = EXCLUDED.""Status"",
			""DueDate"" = EXCLUDED.""DueDate"",
			""InstanceNumber"" = EXCLUDED.""InstanceNumber"",
			""CompletionType"" = EXCLUDED.""CompletionType"";

drop function main.get_status;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
