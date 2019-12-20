alter table Employees Add foreign key  
(DepartmentId) references Departments(Id)  
  
alter table UserRoleMappings Add foreign key(UserId)  
references Users(Id)  
  
alter table UserRoleMappings Add foreign key(RoleId)  
references Roles(id)